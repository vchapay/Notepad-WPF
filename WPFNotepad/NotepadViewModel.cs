using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Input;

namespace WPFNotepad
{
    internal class NotepadViewModel : INotifyPropertyChanged
    {
        private string _text;
        private string _filePath = string.Empty;
        private bool _isSaved = true;

        public NotepadViewModel()
        {
            OpenFileCommand = new RelayCommand(OpenFile);
            SaveFileCommand = new RelayCommand(SaveFile, CanSave);
            SaveAsFileCommand = new RelayCommand(SaveAsFile, CanSave);
            CreateFileCommand = new RelayCommand(CreateFile);
        }

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                _isSaved = false;
                OnPropertyChanged(nameof(Text));
                SaveFileCommand.RaiseCanExecuteChanged();
                SaveAsFileCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand OpenFileCommand { get; }

        public RelayCommand SaveFileCommand { get; }

        public RelayCommand SaveAsFileCommand { get; }

        public RelayCommand CreateFileCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OpenFile()
        {
            if (!_isSaved)
            {
                if (MessageBox.Show("Удалить несохраненные изменения?",
                    string.Empty, MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                    return;
            }

            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.DefaultExt = ".txt";
            if (dialog.ShowDialog() == true)
            {
                Text = File.ReadAllText(dialog.FileName);
            }

            _filePath = dialog.FileName;
            _isSaved = true;
        }

        private void SaveFile()
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                SaveAsFile();
                return;
            }

            File.WriteAllText(_filePath, Text);
            _isSaved = true;
        }

        private void SaveAsFile()
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.DefaultExt = ".txt";
            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, Text);
                _isSaved = true;
                _filePath = dialog.FileName;
            }
        }

        private void CreateFile()
        {
            if (!_isSaved)
            {
                if (MessageBox.Show("Удалить несохраненные изменения?",
                    string.Empty, MessageBoxButton.YesNo) != MessageBoxResult.Yes)
                    return;
            }

            Text = string.Empty;
            _filePath = string.Empty;
            _isSaved = true;
        }

        private bool CanSave()
        {
            return !string.IsNullOrWhiteSpace(_text);
        }
    }
}

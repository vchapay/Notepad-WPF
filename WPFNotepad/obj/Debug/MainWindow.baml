   M S B A M L   `   `   `  ����E  AWPFNotepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPFNotepad
WPFNotepad  5   	       WPFNotepad.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPFNotepad     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	      !  WPFNotepad.NotepadViewModel  5
   
    � 	Resources 5         	ItemStyle �� Property �� Value  TextBoxStyle��%�   &	        &	 h     �� 5   
   .�5      ��  � ��$ 16(�61   �� 5       � ��$ Consolas)�63   5      �� 5   
   .�5      ��  � ��$ 16(�61   �� 5       � ��$ Consolas)�63   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      .+�5   
   o� .@�5      m� $
��File��6   #��[  6%   .@�5      m� $
��Open��6   #��[  6)    m� Command 5      �� *OpenFileCommand+m� 5      $��Create��6   #��[  6+    5       �� *CreateFileCommand+m� 5!      $
��Save��6   #��[  6)    5"      �� *SaveFileCommand+m� 5#      $��Save as��6   #��[  6,    5$      �� *SaveAsFileCommand+5%      5&      �� 5'   
   $��Stretch=�5(      $��Stretch=�5)      $��1��5*       �� TextWrapping$
 Wrap=�5+       �� AcceptsReturn . #��[ 5.      ��5,      �� *Text+	 �� UpdateSourceTrigger$	 PropertyChanged=�5.      5/      50      
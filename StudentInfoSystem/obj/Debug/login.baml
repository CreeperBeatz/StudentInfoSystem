   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5      K*clr-namespace:StudentInfoSystem.ViewModelsStudentInfoSystem.ViewModels  5          StudentInfoSystem.login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      1localclr-namespace:StudentInfoSystem     5      9vm*clr-namespace:StudentInfoSystem.ViewModels     5        � Title$  login��5
      $	��450��6   $	��800��6    ��5      �� 5   
    �� ImageSource$ /Images/voltron.jpg��6    � DataContext 5      *   $StudentInfoSystem.ViewModels.LoginVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   �� $��1��6   $��1��6    ��5      �� 5      
�������._�5       �� $��Login information��6   6:   5!      .��5#      � 
����  � 5$      �� 5%      6)   �� 5&      6)    5(      �� 5)      6&   �� 5*      6&   �� 5+      $
��0.5* �6$   64   .+�5-      �� $��0��6   $��0��6%   $��SegoeUI)�65   
�������$��20(�6]   $��Bottom=�6k   $��Center=�6�   .��6�   
Username6�   �� 5.      $��0��6   $��1��6%   $��SegoeUI)�65   
�������$��20(�6]   $��Bottom=�6k   $��Center=�6�   .��6�   
Password6�   �� 5/      -   5         ��Name$ username_textbox��5/       �� TextWrapping$
 Wrap=�6s   $��0��6�   $��1��6�   $��15q�6�   ��64   �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 50      -   5        $ password_textbox��50      $
 Wrap=�6s   $��1��6�   $��1��6�   $��15q�6�   ��64   �� *
Password+$ PropertyChanged=�6�   �� 51      -   5         ��Name$ login_button��51      $��1��6/   $��2��6?   $��Login��6L   ��6\   �� *LoginCommand+52      53      54      55      
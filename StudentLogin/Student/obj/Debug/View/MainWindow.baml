   M S B A M L   `   `   `  ����B  >Student, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMApp.ViewModelMVVMApp.ViewModel  5   	       MVVMApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1loginclr-namespace:MVVMApp.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5         MVVMApp.ViewModel.LoginVM  5   
   -   5        objStud��5      .��5	      � .+�5
   
   �� -   5        $��lblUserName��5
      $��Username��6#   $
��Left=�66   $��
89,108,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $��txtUserName��5      $
��Left=�6%   $��23��6@   $��164,110,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   ��6�   �� *txtUserName+�� 5   
   -   5        $��lblPassword��5      $��Password��6#   $
��Left=�66   $��
89,175,0,0q�6Q   $	��Top=�6e   G� 5   
   -   5        $��txtPassword��5      $
��Left=�6)   $��23��6D   $��164,178,0,0q�6P   $	��Top=�6e   $	��120��6}    G� PasswordChar 6�   �� *txtPassword+�� 5   
   $��Login��6   $
��Left=�6!   $��164,235,0,0q�6<   $	��Top=�6Q   $��75��6i   ��6t   �� *
LoginCmd+ �� Mode$ OneWay=�5      5      
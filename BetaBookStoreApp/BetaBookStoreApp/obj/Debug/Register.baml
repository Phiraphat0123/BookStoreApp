   M S B A M L   `   `   `  ����K  GBetaBookStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BetaBookStoreAppBetaBookStoreApp  5   	       BetaBookStoreApp.Register   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BetaBookStoreApp     5   	     � Title$  Register��5   	   $��480.473��6   $	��450��6*   $��474.4��6:   $	��460��6K   .��5	      � ���	#FF4D5784$��
0,0,-0.6,0q�6"   .+�5
   
   �� -   5         ��Name$ BSeachEM��5
      $��  Show All Employee��6#   $
��Left=�6A   $
��48.8��6\   $��269.667,213,0,0q�6j   $	��Top=�6�   $��169.133��6�   $��16(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6   � UseLayoutRounding .  ���	#FFFCE2C8���	#FFFF748A��6[  Z� 6r  �� 5   
   -   5        $ 	BDeleteEm��5      $��Delete Employee��6$   $
��Left=�6>   $��49��6Y   $��270,281,0,0q�6e   $	��Top=�6z   $	��169��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A��6�   Z� 6  �� 5   
   -   5        $ BEditEm��5      $��Edit Employee��6"   $
��Left=�6:   $��48��6U   $��270,147,0,0q�6a   $	��Top=�6v   $	��169��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A��6�   Z� 6�   �� 5   
   -   5        $ BAddEm��5      $��Add Employee��6!   $
��Left=�68   $��49��6S   $��
270,83,0,0q�6_   $	��Top=�6s   $	��169��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A��6�   Z� �� 5   
   $��1q�6   $
��Left=�6%   $��45��6@   $	��Top=�6L   $	��477��6d   $
��-1,0q�6p   ���	#FF6F97B16~   �� 5   
   -   5        $ BHome��5      $
��Home��6    $��28��6/   $��	393,6,0,0q�6;   $	��Top=�6N   $��64��6f   ���	#FFFF748A$
��Bold"�6�   ���	#FFFCE2C8$
��Left=�6�   $��Center=�6�   $��1q�6   � IsSharedSizeScope . $��RightToLeft=�6E  $��Center=�6a  ��6�   Z� 6a  �� 5   
   $
��Left=�6   $��24��6+   $��	31,10,0,0q�67   $	��Top=�6J   $��57��6b   $��storytelling.png��6m   �� 5   
   $
��Left=�6   $��57,6,0,0q�6/   $
��Wrap=�6A   $��Bright��6U   $	��Top=�6c   $��21��6{   $��45��6�   $
��Bold"�6�   ���	#FFB7DED7$��14(�6�   �� 5   
   $
��Left=�6   $��	57,23,0,0q�6/   $
��Wrap=�6B   $��
Book Store��6V   $	��Top=�6h   $��21��6�   $��78��6�   $��10(�6�   ���	#FFB7DED76�   �� 5   
   -   5         ��Name$ txtIdEm��5      $
��Left=�6#   $��25��6>   $��	41,99,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��101��6�   $��16(�6�   ���	#FFB7DED7��6�   Z� 6�   �� 5   
   -   5        $ txtPw��5      $
��Left=�6!   $��25��6<   $��
41,150,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��101��6�   $��16(�6�   ���	#FFB7DED7��6�   Z� 6�   �� 5   
   $
��Left=�6   $��
41,129,0,0q�6/   $
��Wrap=�6C   $��Password��6W   $	��Top=�6g   $
��Bold"�6   ���	#FFFCE2C86�   �� 5   
   $
��Left=�6   $��	41,78,0,0q�6/   $
��Wrap=�6B   $��Employee ID��6V   $	��Top=�6i   $
��Bold"�6�   ���	#FFFCE2C86�   �� 5   
   $
��Left=�6   $��
41,186,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��8(�6o   $	��224��6|   $	��169��6�   �� 6�   $���	- Adding information generates an ID and generates a password in the following ways: The ID must be generated from 4-10 digits and the password can be anything. (Numbers or letters) 6-10 characters, but the leading zeros should not be set in the ID section.	��6�   �� 6�  �� 6�  $���	- Editing information will only edit the Password information, if you can't remember the password by the following methods, enter Employee ID in Employee ID field and enter (new) code that you want to change in the field. Password and press the Edit button.��6�  �� 6�  �� 6�  $^�X	- Show All Employee Button is to show all employee IDs and passwords (but not managers)��6�  �� 6E  �� 6Q  $���	- To delete the information is to remove the ID and Password information from the system, the method is to enter the ID number and password in the field and press the button delete.��6U  6  5      5      
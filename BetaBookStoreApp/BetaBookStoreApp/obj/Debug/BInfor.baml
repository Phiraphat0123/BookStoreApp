   M S B A M L   `   `   `  ����K  GBetaBookStoreApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BetaBookStoreAppBetaBookStoreApp  5   	       BetaBookStoreApp.BInfor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:BetaBookStoreApp     5   	     � Title$  Book information��5   	   $	��460��6"   $��480.473��6/   .��5	      � ���	#FF4D5784.+�5
   
   �� -   5         ��Name$ AddBook��5
      $��Add Book��6"   $
��Left=�65   $��
268,62,0,0q�6P   $	��Top=�6d   $	��169��6|   $��49��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A��6�   Z� 6�   �� 5   
   -   5        $ EditBook��5      $��	Edit Book��6#   $
��Left=�67   $��268,131,0,0q�6R   $	��Top=�6g   $	��169��6   $��49��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A��6�   Z� 6�   �� 5   
   -   5        $ ShowAllBook��5      $��Show All Book��6&   $
��Left=�6>   $��268,205,0,0q�6Y   $	��Top=�6n   $	��169��6�   $��49��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A��6�   Z� 6  �� 5   
   -   5        $ 
DeleteBook��5      $��Delete Book��6%   $
��Left=�6;   $��268,272,0,0q�6V   $	��Top=�6k   $	��169��6�   $��49��6�   $��16(�6�   $
��Bold"�6�   ���	#FFFCE2C8���	#FFFF748A6�   �� 5   
   $��1q�6   $
��Left=�6%   $��45��6@   $	��Top=�6L   $	��476��6d   $��-1,0,-0.6,0q�6p   ���	#FF6F97B16�   �� 5   
   $
��Left=�6   $��24��6+   $��	31,10,0,0q�67   $	��Top=�6J   $��57��6b   $��storytelling.png��6m   �� 5   
   $
��Left=�6   $��57,6,0,0q�6/   $
��Wrap=�6A   $��Bright��6U   $	��Top=�6c   $��21��6{   $��45��6�   $
��Bold"�6�   ���	#FFB7DED7$��14(�6�   �� 5   
   $
��Left=�6   $��	57,23,0,0q�6/   $
��Wrap=�6B   $��
Book Store��6V   $	��Top=�6h   $��21��6�   $��78��6�   $��10(�6�   ���	#FFB7DED76�   �� 5   
   -   5         ��Name$ txtISBN��5      $
��Left=�6#   $��25��6>   $��	45,76,0,0q�6J    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��169��6�   $��16(�6�   ���	#FFB7DED7��6�   Z� 6�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��25��6E   $��
45,158,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��169��6�   $��16(�6�   ���	#FFB7DED7��6�   Z� 6�   �� 5   
   -   5        $ txtTitle��5      $
��Left=�6$   $��25��6?   $��
45,117,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��169��6�   $��16(�6�   ���	#FFB7DED7��6�   Z� 6�   �� 5   
   -   5        $ txtPrice��5      $
��Left=�6$   $��25��6?   $��
45,198,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��169��6�   $��16(�6�   ���	#FFB7DED7��6�   Z� 6�   �� 5   
   $
��Left=�6   $��	45,60,0,0q�6/   $
��Wrap=�6B   $
��ISBN��6V   $	��Top=�6b   $
��Bold"�6z   ���	#FFFCE2C86�   �� 5   
   $
��Left=�6   $��
45,182,0,0q�6/   $
��Wrap=�6C   $��Price��6W   $	��Top=�6d   $
��Bold"�6|   ���	#FFFCE2C86�   �� 5   
   $
��Left=�6   $��
45,142,0,0q�6/   $
��Wrap=�6C   $��Description��6W   $	��Top=�6j   $
��Bold"�6�   ���	#FFFCE2C86�   �� 5   
   $
��Left=�6   $��
45,101,0,0q�6/   $
��Wrap=�6C   $��Title��6W   $	��Top=�6d   $
��Bold"�6|   ���	#FFFCE2C86�   �� 5   
   -	   5        $
 Back��5      $
��Back��6   $
��Left=�6.   $��22��6I   $��
369,12,0,0q�6U   $	��Top=�6i   $��61��6�   ���	#FFFF748A���	#FFFCE2C8$
��Bold"�6�   ��6�   Z� 6�   �� 5   
   $
��Left=�6   $	��193��6/   $��
46,227,0,0q�6<   $
��Wrap=�6P   $	��Top=�6d   $	��169��6|   $��10(�6�   �� 6�   $	�	- ��6�   �� 6�   $]�WAdding customer ID information must not have a leading zero and can be any 4-10 digits.��6�   �� 6  �� 6  $���	-  In order to edit information, you must enter the ISBN that matches the ISBN information from then on before entering new information in other fields.��6!  �� 6�  �� 6�  $m�g	- The show will show all information, but if input ISBN, it will show ISBN, Title, Description, Price.��6�  �� 6M  �� 6Y  $6�0	- Deleting is required Customer ID information.��6]  6�  5      5      
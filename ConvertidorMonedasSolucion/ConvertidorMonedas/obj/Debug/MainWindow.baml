   M S B A M L   `   `   `  ����M  IConvertidorMonedas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ConvertidorMonedasConvertidorMonedas  5   	   #    ConvertidorMonedas.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ConvertidorMonedas     5   	     � Title$  
MainWindow��5   	   $��357.2��6   $��303.6��6+   .��5	      � .+�5
   
   �� -   5         ��Name$ btnConvertir��5
      $��	Convertir��6'   $
��Left=�6;   $��134,198,0,0q�6V   $	��Top=�6k   $	��120��6�   $��36��6�    J� RenderTransformOrigin$ 0.75,-1.708&�6�   6�   �� 5   
   -   5         ��Name$ 	txtMoneda��5      $
��Left=�6%   $��23��6@   $��
134,90,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ txtCantidad��5      $
��Left=�6'   $��23��6B   $��134,140,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   $��Valor:��6   $
��Left=�6!   $��	44,87,0,0q�6<   $	��Top=�6O   �� 5   
   $��	Cantidad:��6   $
��Left=�6$   $��
44,137,0,0q�6?   $	��Top=�6S   �� 5   
   $��
Resultado:��6   $
��Left=�6%   $��
44,269,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ txtResultado��5      $
��Left=�6(   $��23��6C   $��134,272,0,0q�6O   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��120��6�   �� 5   
   $��Moneda:��6   $
��Left=�6"   $��	44,31,0,0q�6=   $	��Top=�6P   �� 5   
   -   5         ��Name$ cboTiposDeMonedas��5      $
��Left=�6.   $��
134,31,0,0q�6I   $	��Top=�6]   $	��120��6u   6�   5      5      
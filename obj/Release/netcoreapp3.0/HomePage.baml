   M S B A M L   `   `   `  ���� I  EHyperTicTacToe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HyperTicTacToeHyperTicTacToe      HyperTicTacToe.HomePage   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:HyperTicTacToe       N� Title$  HomePage��$	��300��$	��200��.��� ����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ #29B6F6�� � Offset$
 0.15Q�� $ #69F0AE��$
 0.65Q� � ColumnDefinitions �� $	��200 � � RowDefinitions �� $��50 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 ��� $��40 �.+��� $��0,0,0,0q�$��20(�$��Italic$�$��	ExtraBold"�$��	Noto Sans)����#3333CC$��0��$��0��$��Center=�$��Center=� J� Opacity$	 0.8Q�.��Hyper Tic Tac Toe�� -   $��string_mode��$��0,0,0,0q�$��18(�$
��Bold"�$��	Noto Sans)����#FFFFFF$��0��$��3��$��Center=�$��Bottom=�.��
Grid Size:�� -   $��gameMode��$��0��$��4��$��80��$��25��$��Center=�$	��Top=�
���\\��$
��Bold"�.@��� $��2q����#211F1F$��2q�$��Center=� �� 
IsSelected$
 True��.��3 x 3�� $��2q����#211F1F$��2q�$��Center=�.��4 x 4�� $��2q����#211F1F$��2q�$��Center=�.��5 x 5�� $��2q����#211F1F$��2q�$��Center=�.��6 x 6�� -   $��string_Language��$��0,0,0,0q�$��18(�$
��Bold"�$��	Noto Sans)����#FFFFFF$��0��$��1��$��Center=�$��Bottom=�.��	Language:�� -   $��	languages��$��0��$��2��$��80��$��25��$��Center=�$	��Top=�
���\\��$
��Bold"�.@��� $��2q����#211F1F$��2q�$��Center=�$
 True��.��	English�� $��2q����#211F1F$��2q�$��Center=�.��Polski�� -   $��string_playGame��$��0��$��5��$��0,0,0,0q�$	��125��$��25��
����������#0cb500$��15(�$
��Bold"�$��Corbel)�$��Center=�.��
Start Game�� -   $��string_exit��$��0��$��6��$��0,0,0,0q�$	��125��$��25��
���  ��
�������$��15(�$
��Bold"�$��Corbel)�$��Center=�.��Exit
   M S B A M L   `   `   `  ����K  GWPFProyectoFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFProyectoFinalWPFProyectoFinal  5   	   !    WPFProyectoFinal.Aplicacion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPFProyectoFinal     5   	   -   5          � Title$  Aplicacion TTS��5   	   $	��441��6    $	��800��6-   
������$	��441��6T   $	��441��6d   $	��800��6t   $	��800��6�    � Icon$ 	Icono.ico��6�   .��5	      � ���	#FFD0BEFF.+�5
   
   �� -   5         ��Name$ TxtSintetizar��5
      $
��Left=�6)   $	��233��6D   $��
15,149,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $��Insertar el texto aquí��6y   $	��Top=�6�   $	��321��6�   $��Microsoft Sans Serif)�6�   o� 5   
   $��Stretch=�6   $��26��6-   $	��Top=�69   $
��Auto��6Q   ���	#FFC5FAFF$��14(�6u   .@�5      m� $��Archivo��6   $��Microsoft Sans Serif)�6(   $��14(�6J   $��26��6X   $��Stretch=�6d   .@�5      m� -   5         m�Name$ 	MenuFirma��5      $��Firma��6.   ���	#FFE9EBFD6T   m� 5      -   5        $ 
MenuBiblio��5      $��Bibliografía��6/   ���	#FFE9EBFD6\   m� 5      -   5        $ MenuRegresar��5      $��Regresar��61   ���	#FFE9EBFD6Z   m� 5      -   5        $ 	MenuSalir��5      $��Salir��6.   ���	#FFE9EBFD6T   5      5      �� 5   
   ���	#FF000068$��Center=�6,   $��
21,34,23,0q�6I   $
��Wrap=�6]   $&�� APLICACIÓN TEXT-TO-SPEECH (TTS)��6q   $	��Top=�6�   $��55(�6�   $	��748��6�    �� TextAlignment$ Center=�6�   $��Gabriola)�6�   $��78��6�   $
��Bold"�6  �� 5   
   $��Configuración��6   $
��Left=�6*   $	��159��6E   $��352,127,0,0q�6R   $	��Top=�6g   $	��416��6   $��Tahoma)�6�   $��16(�6�   .��5      � $
��Left=�6   $
��Auto��63   $	��Top=�6A   $
��Auto��6Y   $��10,15,-12,-23q�6f   .+�5      �� $��
Velocidad:��6   �� 5      -   5         ��Name$ SldVelocidad��5      $��38��6/   $	��231��6;    � Minimum$	 -10Q�6G    � Maximum$ 10Q�6U   	 �� TickPlacement$	 BottomRight=�6b   
 �� TickFrequency$
 1Q�6~    �� IsSnapToTickEnabled . $��20,0,0,0q�6�   �� 5      -   5         ��Name$ TxtRate��5      $��20,0,0,0q�6�   $
��Auto��6�   ��6-   ��  �� ElementName$ SldVelocidad�� �� Path$ Value� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��	Volumen: ��6   �� 5      -	   5        $ 
SldVolumen��5      $��38��6-   $	��231��69   $ 0Q�6E   $	 100Q�6Q   $	 BottomRight=�6_   $
 1Q�6{    . $��20,0,0,0q�6�    � Value$ 50Q�6�   �� 5      -
   5        $ TxtVol��5      $��20,0,0,0q�6�   $
��Auto��6�   ��6,   �� $ 
SldVolumen��$ Value�$ PropertyChanged=�6�   �� 5      $"��Seleccionar Tipo de Voz:    ��6   �� 5      -   5         ��Name$ 	CmbxVoces��5      $	��193��6.   5      5      �� 5    
   -   5         ��Name$ 
BtnIniciar��5       $��Iniciar��6%   $
��Left=�67   $��370,340,0,0q�6R   $	��Top=�6g   $��75��6   $��Microsoft Sans Serif)�6�   $��14(�6�   �� 5!   
   -   5        $ 	BtnPausar��5!      $��Pausar��6$   $
��Left=�65   $��470,340,0,0q�6P   $	��Top=�6e   $��75��6}   $��Microsoft Sans Serif)�6�   $��14(�6�   �� 5"   
   -   5        $ BtnReanudar��5"      $��Reanudar��6&   $
��Left=�69   $��570,340,0,0q�6T   $	��Top=�6i   $��75��6�   $��Microsoft Sans Serif)�6�   $��14(�6�   �� 5#   
   -   5        $ BtnFin��5#      $��	Finalizar��6!   $
��Left=�65   $��670,340,0,0q�6P   $	��Top=�6e   $��75��6}   $��Microsoft Sans Serif)�6�   $��14(�6�   6�   �� 5$   
   $��17,127,456,255q�6   $��Tahoma)�6,   $��16(�6@   �� 6P   $�Texto a ��6T   �� 6f   $�
reproducir��6j   �� 6~   $�:��6�   6�   5%      5&      
   M S B A M L   `   `   `  ����K  GWPFProyectoFinal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPFProyectoFinalWPFProyectoFinal  5          WPFProyectoFinal.Def   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WPFProyectoFinal     5        N� Title$!  Introducción y Definición��5	      .��5      � .+�5   
   �� $
��Left=�6   $	��430��6/   $��	10,10,0,0q�6<   $
��Wrap=�6O   $	��Top=�6c   $	��450��6{    �� TextAlignment$ Justify=�6�   $��Arial)�6�   $��16(�6�   ���	#FF060606�� 6�   .�6�   �� $���La forma más habitual de comunicación entre las personas y las máquinas suele ser a través de una pantalla o visualizador, en la que el usuario lee una determinada información. Sin embargo, resulta más agradable poder recibir ciertas informaciones de la misma manera que las comunicamos entre personas: mediante una comunicación oral en nuestro propio idioma. En la actualidad, podemos tener un sistema equivalente a la presencia de una persona que nos vaya leyendo el texto. Sin lugar a dudas, estos sistemas resultan de gran utilidad para invidentes,��6�   6  �� 6  .�6!  �� $� ��6%  61  �� 67  .�6=  �� $���situaciones con poca iluminación en las que no resulta factible realizar una lectura, dispositivos en los que es más económico o práctico incorporar un altavoz que una pantalla, etc.��6A  6  �� 6  �� 6  .�6  �� 6!  �� 6'  �� 63  .�69  �� $
�La ��6=  6K  �� 6Q  $
��Bold"�6V  .�6i  �� $�síntesis de habla��6m  6�  �� 6�  .�6�  �� $v�p es la producción artificial del habla. El sistema computarizado que es usado con este propósito es llamado ��6�  6  �� 6  $
��Bold"�6  .�6.  �� $�computadora de habla��62  6Q  �� 6W  .�6]  �� $� o ��6a  6o  �� 6u  $
��Bold"�6z  .�6�  �� $�sintetizador de voz��6�  6�  �� 6�  .�6�  �� $/�) y puede ser implementado en productos ��6�  6�  �� 6�  .�6�  �� $�software��6  6  �� 6  .�6   �� $ � o hardware. Un sistema ��6$  6G  �� 6M  $
��Bold"�6R  .�6e  �� $�text-to-speech (TTS)��6i  6�  �� 6�  .�6�  �� $��� convierte el lenguaje de texto normal en habla; otros sistemas recrean la representación simbólica lingüística como transcripciones fonéticas en habla��6�  6:  �� 6@  �� 6L  $� ��6P  6[  �� 5   
   $
��Left=�6   $	��100��6+   $��
532,28,0,0q�68   $	��Top=�6L   $	��100��6d    J� RenderTransformOrigin$ 0.245,0.425&�6p   �� 5   
   $
��Left=�6   $	��158��6+   $��
590,98,0,0q�68   $	��Top=�6L   $	��164��6d   $��
DefTTS.png��6p   $
��Fill=�6�   � 5   
   $
��Left=�6   $	��148��6*   $��538,261,0,0q�67   $	��Top=�6L   $	��260��6d   .+�5      �� -   5         ��Name$ btnPlay��5      $
��Play��6&   $
��Left=�65   $��
52,119,0,0q�6P   $	��Top=�6d   $��36��6|   6�   �� 5      -   5        $ btnStop��5      $
��Stop��6&   $
��Left=�65   $��179,119,0,0q�6P   $	��Top=�6e   $��36��6}   6�   �� 5      -   5        $ btnPause��5      $��Pause��6'   $
��Left=�67   $��111,119,0,0q�6R   $	��Top=�6g   $��41��6   6�   r� 5      -   5         r�Name$ Audio��5      $
��Left=�6*   $��36��6E   $��10,7,0,0q�6Q   $	��Top=�6c   $��39��6{    r� Source$ SintesisIntro.mp3?�6�    r� LoadedBehavior$ Manual=�6�    r� Stretch$
 Fill=�6�   �� 5      -   5         ��Name$ 	TxtStatus��5      $
��Left=�6+   $��	98,98,0,0q�6F   $
��Wrap=�6Y   $��00:00 / 00:00��6m   $	��Top=�6�   $��76��6�   �� 5      -   5        	 ��Name$	 	SldStatus��5      $
��Left=�6(   $��	21,78,0,0q�6C   $	��Top=�6V   $	��222��6n   6z   �� 5      -   5        $ TxtIntro��5      $
��Left=�6*   $��	10,48,0,0q�6E   $
��Wrap=�6X   $1��+Introducción a la Síntesis de Voz (Audio)��6l   $	��Top=�6�   $	��240��6�   $ Center=�6�   $��Tahoma)�6�   $��13(�6�   5      �� 5   
   -   5        $ TxtIntro_Copy��5      $
��Left=�6+   $��
486,10,0,0q�6F   $
��Wrap=�6Z   $!��INTRODUCCIÓN Y DEFINICIÓN��6n   $	��Top=�6�   $	��354��6�   $ Center=�6�   $��Cambria)�6�   $��27(�6�   $��66��6�   ���	#FF040C2C6�   5      5      
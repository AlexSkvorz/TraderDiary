   M S B A M L   `   `   `  ????F  BTraderDiary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TraderDiaryTraderDiary  5   	       TraderDiary.LogDiary   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TraderDiary     5   	      WindowStyle#???   5   	     ? Title$  LogDiary??5   	   $	??600??6   $	??800??6'    ? WindowStyle$ SingleBorderWindow=?63   
???   ? ? 
ResizeMode$ NoResize=?6g    ? WindowStartupLocation$ CenterScreen=?6}    ? Icon$ images/Logo.png??6?    ? 	Resources 5	        FocusVisual ?? Property ?? Value ?? StrokeDashArray	 J? SnapsToDevicePixels  Button.Static.Background
 ?? Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonStyle1 ?? 
TargetType ?? 
TargetType ??Name ?? CornerRadius ??Name ?? Triggers P? Property P? Value ?? 
TargetName??%?  &	       &	 ?     &	 ?     &	 ?     &	     &	 2    &	 S    &	 t    &		 ?    &	
 ?    &	 ?    7  7  7  7  7  7  7  7  7 	 7 
 &	  ?    ?? 5
   
   .?5      ??  ? ?? 5      ?? 5      .R?5      ?? $??2q?6$   $	 1 2R?6/   #??? ??6E   	 . $??1??6?   5      5      5      ?? 5   
   $
 	#FFDDDDDD??6;   ?? 5   
   $
 	#FF707070??67   ?? 5   
   $
 #000000??6>   ?? 5   
   $
 #ff0000??6:   ?? 5   
   $
 #000000??6<   ?? 5   
   $
 #000000??68   ?? 5   
   $
 	#FFF4F4F4??6=   ?? 5   
   $
 	#FFADB2B5??69   ?? 5   
   $
 	#FF838383??6=   ?? 5   
   " ??6%   .?5      ??  ?@?FocusVisualStyle8   61   ?? 5       ? ??8  6+   ?? 5       ? ??8  6,   ?? 5        ? ??# ? ??6+   ?? 5!       ? ??$ 1q?60   ?? 5"       ? ??$ Center=?6;   ?? 5#       ? ??$ Center=?69   ?? 5$       ? ??$ 1q?6(   ?? 5%       ? ?? 5&      ?? 5'      " ??6&   .R?5(      ?? $ border??6!   #??z??61   #??z??6[   #??z??6?   	 . $ 5??6?   ._?5)      ?? $ contentPresenter??6/   |?.  #??z??6[   #??z??6?   ??. #	 z	 6?   #??z??6  5*       5+      P? 5,       ?@??IsDefaulted . . ?5-   "   ?? $ border??6@   # ? ??6T    ? ??5.      P? 5/       ?@J?IsMouseOver . . ?50   "   ?? $ border??6?   8   ? ??6S   ?? 51   "   $ border??6@   8   ? ??6T   52      P? 53       ? ?? . . ?54   "   ?? $ border??6?   8   ? ??6S   ?? 55   "   $ border??6@   8   ? ??6T   56      P? 57       ? {? .  . ?58   "   ?? $ border??6?   8   ? ??6S   ?? 59   "   $ border??6@   8   ? ??6T   ?? 5:   "   $ contentPresenter??6K   8 	  ? ??6i   5;      5=      5?      5@      ?? 5A   
   " ?6$   .?5B      ??  ? ?? 5C      ?? 5D      " ?6&   .R?5E      ?? 5F      5H      5I      5J      .??5K      ? $	??800??6   $	??600??6   .+?5L   
   ?? -   5         ??Name$ сhooseFileButton??5L   8   #???  6   $??Выбрать файл??6R   $
??Left=?6i   $??100,425,0,0q?6?   $	??Top=?6?   ???	#FF020202$	??600??6?   $??25??6?   ???	#FFE9D1FF$??Cooper Black)?6?   $??16(?6  ???	#FFE9D1FF67  ?? 5M   
   -   5        $ сontinueButton??5M   8   #???  6   $??Продолжить??6P   $??Center=?6e   $??	0,475,0,0q?6?   $	??Top=?6?   ???	#FF020202$	??600??6?   $??25??6?   ???	#FFE9D1FF$??Cooper Black)?6?   $??16(?6  ???	#FFE9D1FF63  r? 5N   
   $
??Left=?6   $	??400??62   $??
100,25,0,0q?6?   $	??Top=?6S   $	??600??6k    r? LoadedBehavior$
 Play=?6w    r? UnloadedBehavior$ Manual=?6?   $y?Visible=?6?    r? Source$ images/Logo.gif??6?   5O      5P      
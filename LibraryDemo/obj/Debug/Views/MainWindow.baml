   M S B A M L   `   `   `  ????F  BLibraryDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LibraryDemo.ViewModelsLibraryDemo.ViewModels  5      ?$clr-namespace:LibraryDemo.ConvertersLibraryDemo.Converters  5      "    LibraryDemo.Views.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5      5
viewModels$clr-namespace:LibraryDemo.ViewModels  5      5
converters$clr-namespace:LibraryDemo.Converters  5      $	??450??5	      $	??800??5
        ? DataContext  5      0   *LibraryDemo.ViewModels.MainWindowViewModel  5       ? 	Resources 5      4   .LibraryDemo.Converters.BoolToResponseConverter   BoolToResponseConverter@   :LibraryDemo.Converters.DoubleValueToValidResponseConverter ' #DoubleValueToValidResponseConverter??%:   &	        &	        5      6'     5      63   5      .??5      ?  ? ColumnDefinitions 5      ?? 5      $??* ?6   ?? 5      $
??Auto ?6   ?? 5      $??* ?6    ? RowDefinitions 5      ?? 5      $
??Auto ?6   ?? 5      $??* ?6   .+?5      ?? $??0??6   $??0??5      $??3??5      $
??0,10q?5       $	??280??5!        RegularButton#??[ 5"      $??Center=?5#      $>??8Проверить произвольную фигуру??6"   ??5$      ?? *&$OpenWindowForCheckCustomShapeCommand+?? 5%      $??0??6   $??1??5&      $??Center=?5'      .+?5(      ??   MainTextBlockStyle#??[ 6   $Q??KПоиск площади треугольника по 3 сторонам:??5)   	     
BlackBrush#??[ 5*   	   $??SemiBold"?5+   	   $??16(?5,   	   $??Center=?5-   	   $??	Underline{?5.   	   $??0,20 q?5/   	   ?? 51       ?? Orientation$ 
Horizontal=?6   $??Center=?52      .+?53      ?? $??SemiBold"?6   $??16(?54   
   $??Center=?55   
   $#??Первая сторона: ??56   
   $??0,0,10,0q?57   
   ?? 58      $	??100??6   $??0??59        TextBoxStyle#??[ 5:        
WhiteBrush ?? 
CaretBrush# [ 5;      #??[ 5<      #??[ 5=      .??61   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5>      +  %Microsoft.Xaml.Behaviors.EventTrigger  5?         	EventName$ TextChanged??6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5@   	   2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  	   PassEventArgsToCommand	 . 
   Command
 6   ?? *!FirstTriangleSideChangedCommand+5A      5B   	   .??5C      5D      5E      ?? 5G      $ 
Horizontal=?6   $??Center=?5H      $??0,20,0,0q?5I      .+?5J      ?? $??SemiBold"?6   $??16(?5K   
   $??Center=?5L   
   $#??Вторая сторона: ??5M   
   $??0,0,10,0q?5N   
   ?? 5O      $	??100??6   $??0??5P      #??[ 5Q      # [ 5R      #??[ 5S      #??[ 5T      .??61    5U        5V      $ TextChanged??6   . 5W   	     	 . 
 6   ?? *" SecondTriangleSideChangedCommand+5X      5Y   	   .??5Z      5[      5\      ?? 5^      $ 
Horizontal=?6   $??Center=?5_      $??0,20,0,0q?5`      .+?5a      ?? $??SemiBold"?6   $??16(?5b   
   $??Center=?5c   
   $#??Третья сторона: ??5d   
   $??0,0,10,0q?5e   
   ?? 5f      $	??100??6   $??0??5g      #??[ 5h      # [ 5i      #??[ 5j      #??[ 5k      .??61    5l        5m      $ TextChanged??6   . 5n   	     	 . 
 6   ?? *!ThirdTriangleSideChangedCommand+5o      5p   	   .??5q      5r      5s      ?? 5u      $??18(?6   $??SemiBold"?5v   	   $??Center=?5w   	   $??0,20,0,0q?5x   	   ?? 5y      $?Результат:??6
    ?? 5z      ?6
   ?? *TriangleArea+ ?? FallbackValue$	 0.0?? ?? 	Converter# [ 5{      ?? 5}      $??18(?6   $??SemiBold"?5~   	   $??Center=?5   	   $??0,20,0,0q?5?   	   ?? 5?      $&? Прямоугольный? — ??6
    ?? 5?      ?6
   ?? *IsTriangleRectangular+# [  5?      5?      ?? 5?      $??1??6   $??1??5?      #??["?5?      $??3??5?      $	??5,0q?5?      #??[ 5?      ?? 5?      $??2??6   $??1??5?      $??Center=?5?      .+?5?      ?? #??[ 6   $???9Поиск площади круга по радиусу:??5?   	   #??[ 5?   	   $??SemiBold"?5?   	   $??16(?5?   	   $??Center=?5?   	   $??	Underline{?5?   	   $??0,20 q?5?   	   ?? 5?      $ 
Horizontal=?6   $??Center=?5?      $??0,20,0,0q?5?      .+?5?      ?? $??SemiBold"?6   $??16(?5?   
   $??Center=?5?   
   $??Радиус: ??5?   
   $??0,0,10,0q?5?   
   ?? 5?      $	??100??6   $??0??5?      #??[ 5?      # [ 5?      #??[ 5?      #??[ 5?      .??61    5?        5?      $ TextChanged??6   . 5?   	     	 . 
 6   ?? *EllipseRadiusChangedCommand+5?      5?   	   .??5?      5?      5?      ?? 5?      $??18(?6   $??SemiBold"?5?   	   $??Center=?5?   	   $??0,20,0,0q?5?   	   ?? 5?      $?Результат:??6
    ?? 5?      ?6
   ?? *EllipseArea+$	 0.0??5?      5?      5?      5?      
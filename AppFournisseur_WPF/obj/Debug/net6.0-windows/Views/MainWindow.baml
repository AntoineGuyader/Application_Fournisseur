   M S B A M L   `   `   `  ????M  IAppFournisseur_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppFournisseur_WPFAppFournisseur_WPF  5   	   #    AppFournisseur_WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AppFournisseur_WPF     5   	     ? Title$  
MainWindow??5   	   $	??800??6   $
??1200??6)    ? 
ResizeMode$ NoResize=?5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	    ? WindowStyle$
 None=?5   	   .??5      ? ???#272537 ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      .+?5   
   ?? $??Fournisser App??6   
???????$??22(?5   #   $??0??5      $??0??6    $??Center=?5      $??Center=?5      $??Microsoft Sans Serif)?5      $
??Bold"?62   ?? 5!   
   -   5         ??Name$ mainPageSearchBar??5!      $??1??5"      $??0??6"      Main_SearchBar#??[  5#      ?? 5%   
   -   5         ??Name$ BtnRechercher??5%      $??
Rechercher??6(   $??1??5&      $??0??6!     	Basic_Btn#??[ 5'      $??292,25,608,25q?5)      ?? 5,   
   -   5        $??X??5,      #??[ 5-      $??1??5.      $??0??6!   $??Right=?5/      $??0,0,40,0q?50      $
??Bold"?6#   ???	#FFD84141$??20(?51   (   $??40??52      $??40??6   ?? 5H   
   $??0??6   $??1??6%   .+?5I      	? -   5        $??Btn_Home??5J   ,     Main_Menu_Btn#??[ 5I      $??Accueil??5J      5K      	? 5L      -   5        $??Btn_Command??5M   8   #??[ 5L      $??Passer une commande??5M      5N      	? 5O      -   5        $??Btn_Suppliers??5P   :   #??[ 5O      $??Liste des fournisseur??5P      5Q      	? 5R      -   5        $??Btn_Articles??5S   7   #??[ 5R      $??Liste des produits??5S      5T      	? 5U      -   5        $??Btn_Adresse??5V   -   #??[ 5U      $??Adresses??5V      5W      	? 5X      -	   5        $??Btn_Test??5Y   )   #??[ 5X      $
??test??5Y      5Z      5[       ? 5_   
   -
   5          ?Name$ 	MainFrame??5_      $??	0,0,20,20q?6$   	  ? NavigationUIVisibility$	 Hidden=?5`      ???#3D3951$??1??5b      $??1??6    5d      5e      
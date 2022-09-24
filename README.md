# Start_HD_SDT
 
This GUI application fixes a few issues with SDT and the Flash projector, hopes to greatly improve performance for CPUs with greater than 4 processors, and add some QoL features.

Uses an included copy of Flash player 10.3 which is the fastest for SDT

Now allows you to search your PC for any prefered Flash Player or Loader location

Sets the Flash player to your CPUs max affinity(logical processors)
This shouldn't matter but I've see the affinity set wrong sometimes. If your CPU has more than 4 logical processors you will see a performance gain. Your max number of threads is detected and set by default, you can only lower it.

Sets the Flash player to High Priority
This should generally improve performance

Allows you to choose an HD starting resolution
Now includes a few more resolutions
Previously the flash player's outer window bounds was set, now the inner game area is set to the exact resolution including when Windows 10/11 is scaled above 100%

Fixes a Windows scaling issue, when the desktop is scaled above 100%, with the Flash player that caused blurry edges and text
This is done by setting the following regestry key: @"HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Layers" "Application path" "HIGHDPIAWARE"

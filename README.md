# ToolOPT6 Calculator


This is an app created for helping user to enable some greyed-out ToolOPT6 Settings in EZ-Adjust menu, this can potentially brick your tv and cause it to malfunction.  
For enter the EZ-Adjust menu just Google it ;)  
Without an official LG USB dongle used by authorized service centres, most of that option will be greyed out, but manipulating the code in the correct way you can change the values without even unlocking them

![alt text](https://github.com/ca0ss/ToolOPT6-Calculator/blob/master/ToolOPT6%20example.jpg)



The code shown is the decimal representation of a binary number of which each bit (or groups of it) represents specific flags
After some test, trial and error and educated guess I manage to decode the method how LG save the settings on ToolOPT6 menu on my 55UP75006LF

00 1001 0111 0000 1100 1100 0000 10XX == Digital Eye  
00 1001 0111 0000 1100 1100 0000 1X11 == Energy Star  
00 1001 0111 0000 1100 1100 0000 X011 == adaptive dim default  
00 1001 0111 0000 1100 1100 XXXX 1011 == adaptive dimming  
00 1001 0111 0000 1100 XXXX 1001 1011 == echo Default Backlight  
00 1001 0111 0000 11XX 1100 0000 1011 == Sound Mode  
00 1001 0111 0000 1X00 1100 0000 1011 == ISF  
00 1001 0111 0000 X100 1100 0000 1011 == Set ID  
00 1001 0111 000X 1100 1100 0000 1011 == Support ATV DVR  
00 1001 0111 00X0 1100 1100 0000 1011 == DVR ready  
00 1001 0111 0X00 1100 1100 0000 1011 == Audio Line OUT  
00 1001 011X X000 1100 1100 0000 1011 == Wifi_BT  
00 1001 XXX1 0000 1100 1100 0000 1011 == Wifi ASsy  
00 100X 0111 0000 1100 1100 0000 1011 == Motion Remocon  
00 1XX1 0111 0000 1100 1100 0000 1011 == Audio EQ/ Eye  
0X X001 0111 0000 1100 1100 0000 1011 == EDID  
X0 1001 0111 0000 1100 1100 0000 1011 == WiSA  

This is the same thing for the LG OLED 55G36LA

111 0010 0001 0011 1101 0110 0000 10XX == Digital Eye  
111 0010 0001 0011 1101 0110 0000 1X11 == Energy Star  
111 0010 0001 0011 1101 0110 0000 X011 == adaptive dim default  
111 0010 0001 0011 1101 0110 XXXX 1011 == adaptive dimming  
111 0010 0001 0011 1101 XXXX 0000 10111 == echo Default Backlight  
111 0010 0001 0011 11XX 0110 0000 1011 == Sound Mode  
111 0010 0001 0011 1X01 0110 0000 1011 == ISF  
111 0010 0001 0011 X101 0110 0000 1011 == Set ID  
111 0010 0001 001X 1101 0110 0000 1011 == Support ATV DVR  
111 0010 0001 00X1 1101 0110 0000 1011 == DVR ready  
111 0010 0001 0X11 1101 0110 0000 1011 == Audio Line OUT  
111 0010 000X X011 1101 0110 0000 1011 == Wifi_BT  
111 001X XXX1 0011 1101 0110 0000 1011 == Wifi ASsy  
111 00X0 0001 0011 1101 0110 0000 1011 == Motion Remocon  
111 XX10 0001 0011 1101 0110 0000 1011 == Audio EQ/ Eye  
1XX 0010 0001 0011 1101 0110 0000 1011 == EDID  
X11 0010 0001 0011 1101 0110 0000 1011 == WiSA  


#WARNING  
I'm not responsable of bricking your TV! remember to copy and save your original code.  
~I don't test what can appen if you input a wrong code or make an "out of bound" selection for and example a theoretical "Step 13" (1100 in binary)  on "Adaptive Dimming" selection.~  
If you input a wrong code that make an "out of bound" selection, the TV simply adjust it to a valid value in most of case. I try to enable DTS on both G3 and 75UP tv, in the first case the tv keep wrong code but does not change "Sound Mode" selection, in the second the tv simply adjust code to a valid value. Should not make any brick.  

Use the software only if:  
1. The menu item showed in your TV are the same showed in the software interface.  
2. Put the code showed in your TV in the software interface and chose Reverse button. The item in yout tv MUST match the item in the software interface.  
3. If clicking on reverse button, software don't show any error.  

#Final thought  
I use this software for enabling Dolby Atmos and unlocking PVR and Time Shift on my TV.  
I found most of the blacked out items via google image searches of the menu in question. I have not directly modified the values of the "Digital eye", ~"sound mode"~, "Wifi/BT", the items reported in the program are the result of educated guess based on other tv and redundant value in multiple tv having same menu items.  
Sound mode in newest tv should be only 00 for LG Sound Engine and 01 for Dolby Atmos. DTS Virtual X option shouldnt be present on all tv, but i keep it there for test.  
I personally test "Audio EQ/ Eye" option using the code "196200459" finding "Type1" setting. I don't test "Type2" option.  

#Expandig the Project  
If your TV have different menu item, don't use the software but wrote here a new Issue. i will implement it on a new release :)  
If you have ToolOPT6 option locked out, you can unlock it having JailBreak, wrote me on t.me/Ca0ss93

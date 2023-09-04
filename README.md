# ToolOPT6 Calculator


This is an app created for helping user to enable some greyed-out ToolOPT6 Settings in EZ-Adjust menu, this can potentially brick your tv and cause it to malfunction.

Without an official LG USB dongle used by authorized service centres, most of that option will be greyed out, but manipulating the code in the correct way you can change the values without even unlocking them

![alt text](https://github.com/ca0ss/ToolOPT6-Calculator/blob/master/ToolOPT6%20Menu.jpg)

![alt text](https://github.com/ca0ss/ToolOPT6-Calculator/blob/master/ToolOPT6%20Calculator.jpg)

The code shown is the decimal representation of a binary number of which each bit (or groups of it) represents specific flags
After some test, trial and error and educated guess I manage to decode the method how LG save the settings on ToolOPT6 menu on my 55UP75006LF

00 1001 0111 0000 1100 1100 0000 10** == Digital Eye

00 1001 0111 0000 1100 1100 0000 1*11 == Energy Star

00 1001 0111 0000 1100 1100 0000 *011 == adaptive dim default

00 1001 0111 0000 1100 1100 **** 1011 == adaptive dimming

00 1001 0111 0000 1100 **** 1001 1011 == echo Default Backlight

00 1001 0111 0000 11** 1100 0000 1011 == Sound Mode

00 1001 0111 0000 1*00 1100 0000 1011 == ISF

00 1001 0111 0000 *100 1100 0000 1011 == Set ID

00 1001 0111 000* 1100 1100 0000 1011 == Support ATV DVR

00 1001 0111 00*0 1100 1100 0000 1011 == DVR ready

00 1001 0111 0*00 1100 1100 0000 1011 == Audio Line OUT

00 1001 011* *000 1100 1100 0000 1011 == Wifi_BT

00 1001 ***1 0000 1100 1100 0000 1011 == Wifi ASsy

00 100* 0111 0000 1100 1100 0000 1011 == Motion Remocon

00 1**1 0111 0000 1100 1100 0000 1011 == Audio EQ/ Eye

0* *001 0111 0000 1100 1100 0000 1011 == EDID

*0 1001 0111 0000 1100 1100 0000 1011 == WiSA

#WARNING
I'm not responsable of bricking your TV! remember to copy and save your original code.
I don't test what can appen if you input a wrong code or make an "out of bound" selection for and example a theoretical "Step 13" (1100 in binary)  on "Adaptive Dimming" selection.

Use the software only if:
1. The menu item showed in your TV are the same showed in the software interface
2. Put the code showed in your TV in the software interface and chose Reverse button. The item in yout tv MUST match the item in the software interface
3. If clicking on reverse button, software don't show any error.

#Final thought
I use this software only fot unlocking PVR and Time Shift on my TV.
I found most of the blacked out items via google image searches of the menu in question. I have not directly modified the values of the "Digital eye", "sound mode", "Wifi/BT", the items reported in the program are the result of educated guess based on other tv and redundant value in multiple tv having same menu items.
I personally test "Audio EQ/ Eye" option using the code "196200459" finding "Type1" setting. I don't test "Type2" option.

# ToolOPT6 Calculator


This is an app created for helping user to enable some greyed-out ToolOPT6 Settings in EZ-Adjust menu, this can potentially brick your tv and cause it to malfunction.  
For enter the EZ-Adjust menu just Google it ;)  
Without an official LG USB dongle used by authorized service centres, most of that option will be greyed out, but manipulating the code in the correct way you can change the values without even unlocking them  

![alt text](https://github.com/ca0ss/ToolOPT6-Calculator/blob/master/ToolOPT6%20example.jpg)



The code shown is the decimal representation of a binary number of which each bit (or groups of it) represents specific flags.  
After some test, trial and error and educated guess I manage to decode the method how LG save the settings on ToolOPT6 menu on my 55UP75006LF.  

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

You will find all the other tv encoding i find on the folder "toolopt6 code test".


#WARNING  
I'm not responsable of bricking your TV! remember to copy and save your original code. 
If you input a wrong code that make an "out of bound" selection, the TV simply adjust it to a valid value in most of case. I try to enable DTS on both G3 and 75UP tv, in the first case the tv keep wrong code but does not change "Sound Mode" selection, in the second the tv simply adjust code to a valid value. Should not make any brick.  

Use the software only if:  
1. The menu item showed in your TV are the same showed in the software interface.  
2. Put the code showed in your TV in the software interface and chose Reverse button. The item in yout tv MUST match the item in the software interface.  
3. If clicking on reverse button, software don't show any error.  

#Final thought  
I personally use this software for enabling Dolby Atmos and unlocking PVR and Time Shift on my TV.  
I found some of the blacked-out items via Google image searches of the menu in question. Some values reported in the program are the result of plausible hypotheses based on other televisions and redundant values in multiple televisions with the same menu items, some are reported by users who helped me by making their televisions available to me.
Sound mode in newest tv should be only 00 for LG Sound Engine and 01 for Dolby Atmos. DTS Virtual X option shouldnt be present on all tv, but i keep it there for try to enable it just in case.  


#Expandig the Project  
If your TV have different menu item, don't use the software but wrote here a new Issue. i will implement it on a new release :)  
If you have ToolOPT6 option locked out, you can unlock it having JailBreak, wrote me on t.me/Ca0ss93  

#FAQ  
Q: My TV model is not listed on "TV Series" field, can I use this tool?  
A: You can use it only if when you put all your toolOPT6 settings on the calculator and it show you your current code; if you need help identifying your tv matching series, try the "Help" button. If you have some trouble, please open a new issue :)  

Q: I don't know how to access that menu.  
A: Just Google "How to access LG Service Menu without the Service Remote"  

Q: When I calculate a code with #any option# selected, the tv won't select that.  
A: I find most of the option online based on picture taken from the tv, maybe some tv have different option. For example some tv have "DTS Virtual X" on Sound Mode, other not.  If entering a code does not obtain the desired effect, for example "LG Sound engine" appears instead of "DTS Virtual X" but the entered code remains unchanged on the TV, I strongly recommend entering a new code consistent with what was calculated; in the example above calculate a new code with "Dolby Atmos" selected instead of "DTS Virtual X"

Q:Even if I enable "DVR Ready" and "Support ATV DVR" option, the TV doesn't seem to support recording, what's wrong?  
A:For some markets, such as Italy for example, there are laws that impose taxes on manufacturers of electronic devices in order to record programs protected by copyright. For this reason LG has blocked these functions if you select one of these countries. You should not change country to Germany to enable PVR and Time Shift ;)

Q: I succesfull reach toolOPT6 menu, but the input field is read only, how i can change it?  
A: You need Jailbreak your tv. Via ROOT command shell it is possible to tamper some qml file thus unlocking the menu. There is no online documentation about it but it's something I've done a couple of times and it's relatively safe. Wrote me on Telegram at https://t.me/Ca0ss93  
Maybe in the future I will write a guide on how to do this, but for now I don't want LG to release a patch that blocks this method;




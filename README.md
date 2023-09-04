# ToolOPT6 Calculator

This is an app created for helping user to enable some greyed-out ToolOPT6 Settings in EZ-Adjust menu


After some test, trial and error i manage to decode the method how LG save the settings on ToolOPT6 menu

00 1001 0111 0000 1100 1100 0000 10** == Digital Eye
00 1001 0111 0000 1100 1100 0000 1*11 == energy star
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

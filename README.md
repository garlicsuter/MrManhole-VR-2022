-----------------------------------------------------------
To Do:
Audio - engine, grinding, etc
Shat silver
Warning sticker (Jamie Sending)
2 combo button reset
A1,A2,A3 with 3 exports of Version A with 3 different sets of questions (Can we do this in ONE app?)
Cheat Code: Sends correct answer (right hand w user, left hand controller with booth person)
video loop of all steps

kerf on
old road off
donut road on (all done via the SS_STL script "SS_Scripted"

-----------------------------------------------------------
Color Codes
Cutter Orange: dd8f00, R-221 G-143 B-0

ZR Scripts:
Question.cs (goes on each question, 1-20). 
- Assign (in Inspector) each of the 4 answers in each questions "Question" script

Score.cs (Goes on GameManager)
- Assign (in Inspector) each of the potential questions to be drawn from

-----------------------------------------------------------


# MrManhole-VR-2022
Positions:



- Final Six Shooter Vector3 (3.962, Y, 0.568) and start(.09,-2.2105,2.255)
- Final "Cylinder-animate this" Vector3() and start()

- Donut skinny mesh starting Vector3 (1.193578,0.176,1.33376) Or (0.7778,-0.023,-0.464)???
- Speedplate("Parent") start Vector3(0,0,0) and final (-1.14,-0.303,0)
- Lid_RingOnly Starting Vector3(1.19338, -.001, 1.332846
Lid_Only Starting Vector3(1.19338,0, 1.332846)
--------------
Blender - Animate Skidloader (no bucket or Mount)
Initial "Location" of S770 (0,0,0)
Initial "Location" of Arm Driver (0,0, 1.6)

100 frames later...

Final "Location" of S770 (0, -7.9, 0)
Final "Location" of Arm Driver (0, 0, 0.91)


- SS Start Spin( ZROT:412): Frame 355, 
frame 385 Zrot +90 = 502. Good.
frame 415 Zrot +90 = 592. Good, with slowdown between. Adjust Curves handles to be inline with escalation to smooth
frame 445 Zrot +90 = 682. Good, more Curves adjustments to make a straight steady 45 degree incline.
frame 475 Zrot +90 = 772.
frame 505 Zrot +90 = 862.
frame 535 Zrot +90 = 952.

LidRing(Donut actually) starting: zPot: 0.015895, new 0.01448

STOP SPINNG FRAME: 555.
- Next will be the white liner moves in, frame added on top, then cement fill, each staggered by more Questions for the user.
- Replace existing grayscale six shooter with "SS-animate this - larger 1" and anim
- Road changes to Kerf Road
- Activate Donut & Animate Donut Removal

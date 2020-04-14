## 2020-04-14
First release of Xtream Midi Forwarder. 

Features are:
- grab input/output midi devices from system
- automatically refresh input/output device list on device switch on/off.
- forward midi events from input midi device to output midi device
- forward midi events from input midi device to Midi Forwarder remote instance using local or Internet network
- Listen to incoming midi event from network and forward them to output midi device
- Midi monitor of incoming midi source
- Midi event filtering (on monitor and midi destination)
- Network configuration and event types filters automatically saved on exit and restored on next launch
- reset midi destination in case of problem with dedicated button
- "about" tab show credits about this software and used libraries. It also allows to display this changelog.

Known bugs/improvement:
- better errors detection when remote Midi Forwarder instance is switched off during listening


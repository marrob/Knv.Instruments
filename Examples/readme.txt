/*** Debug From TestStand ***/
TestStand 2017
Visual Studio 2019 v 2022

1. Tegy�l t�r�spontot abba a C# met�dusba ahol meg szeretn�l �lni
2. V�laszd a Debug-> Attach to Process men�pontot majd v�laszd a SeqEdit.exe-�t a list�b�l
3. Indisd e TestStandbol a progit majd SetpInto-val l�pj bele... 
(elofordulahat hogy feldob egy ilyen ablakot hogy: Warning ... Could not find DIA CLSID for this version of Visual Studio)


NI-VISA .NET Library
https://www.ni.com/hu-hu/support/documentation/supplemental/15/national-instruments-visa--net-library.html

.NET Resources for NI Hardware and Software
https://www.ni.com/hu-hu/support/documentation/supplemental/13/national-instruments--net-support.html


Tipusok
1. Nativ Ethernet TCP/IP - RAW SOCKET - SCPI-RAW (TCP/UDP)(IANA official)
   - Ehhez csak egy IP �s protsz�m kell ami az 5025-�s
   - VISA telep�t�se n�k�l is megy
   - TCPClient vs Socket in C#: https://stackoverflow.com/questions/685995/tcpclient-vs-socket-in-c-sharp
   - https://www.codeproject.com/Articles/302873/Remote-Controlling-Instrument-Over-LAN
   
2. VXI-11 Ethernet
  - pl: TCPIP0::192.168.100.8::inst0::INSTR
  - A TCP/IP f�l�tt m�g egy r�teg van a VXI-11 (https://www.lxistandard.org/about/vxi-11-and-lxi.aspx)
  - Kell Hozz�a NI-MAX �s a VISA 
  - Ezt lehet a "Ivi.Visa.Interop.dll" vagy a "NationalInstruments.Visa.dll"
  - A soroportot biztos lehet haszn�lni VISA telep�t�se n�lk�l kiz�rolag a NationalInstruments.Visa.dll-eket haszn�lva
3. USB
   - VCP
   - USBTMC Driver - USB Test & Measurement Class

/* 
 * --- NI VISA ---
 * NationalInstruments.Visa
 * C:\Program Files(x86)\IVI Foundation\VISA\Microsoft.NET\Framework32\v4.0.30319\NI VISA.NET 19.0\NationalInstruments.Visa.dll
 * C:\Program Files\IVI Foundation\VISA\Microsoft.NET\Framework64\v4.0.30319\NI VISA.NET 19.0\NationalInstruments.Visa.dll

 *Ivi.Visa
 * C:\Program Files(x86)\IVI Foundation\VISA\Microsoft.NET\Framework32\v2.0.50727\VISA.NET Shared Components 5.8.0\Ivi.Visa.dll
 *C:\Program Files\IVI Foundation\VISA\Microsoft.NET\Framework64\v2.0.50727\VISA.NET Shared Components 5.11.0\Ivi.Visa.dll
*/

--- �latal�nos VISA ---
Ivi.Visa.Interop.dll
ezt haszn�lja a Keisight is.




; Hotkey:  Ctrl Shift t  
!c::  
; Remember what was in the clipboard 
clipboardPrev = %clipboard%  
; Clear the clipboard 
clipboard:=  
Sleep,200  
; Send a Ctrl C to copy the current selection 
SendInput, {Ctrl down}c{Ctrl up}  
Sleep,200  
; Get the current selection from the clipboard 
selectedText=%Clipboard%  
if SelectedText = 
{     
; If the first attempt didn't get any test, try again     
Sleep,200      
; Send a Ctrl C to copy the current selection     
SendInput, {Ctrl down}c{Ctrl up}      
; Get the current selection from the clipboard     
selectedText=%Clipboard%  
}  

if SelectedText = 
{
	return
	
}

; Restore the clipboard 
clipboard=%clipboardPrev%  
;MsgBox, %selectedText%  

Send, #{Left}

;run CLUEit_Launcher
;Run, C:\Users\Lou\Documents\Visual Studio 2010\Projects\CLUEit_Launcher\bin\Debug\CLUEit.exe "%selectedText%"
Run, C:\Users\Lou\Desktop\CLUEit.exe "%selectedText%"

Sleep, 200


Loop 1000
{
	IfWinExist CLUEit
	{
		WinActivate
		Send, #{Right}
		break
	}
	else
	{
		Sleep, 200
	}
}

return 

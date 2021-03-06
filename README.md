# Proof of Concept: GDI

Yup, that's right, getting low with GDI (1985), not GDI+ (2001) nor DirectWrite/Direct2D (2008). 

Wanted demonstration of usage with modern tools, so rolled POC using Visual Studio 2012 and Win Forms in CSharp, and dllimported gdi32.dll in order to draw using GDI.  The crux of this was getting the device context in the paint event and creating the mapping layer to the external GDI functions - see GDI.cs.

Here's the initial drawing output from this POC (hopefully timely!):

![Image](logo.png?raw=true)


### References:

[*MSDN - Graphics.GetHdc Method*](http://msdn.microsoft.com/en-us/library/9z5820hw.aspx)

[*Legacy Graphics - Windows GDI*](http://msdn.microsoft.com/en-us/library/windows/desktop/dd145203.aspx)


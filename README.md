# SwedishCoordinates.DotNetCore
Ported to .Net Core 2.1

Convert coordinates between different Swedish coordinate systems, RT90, SWEREF99, WGS84, Web/Spherical Mercator.

Based on https://github.com/bjornsallarp/MightyLittleGeodesy


Convert between RT90 and WGS84

    var rt90 = new RT90Position(lat, lng);
    var wgs84 = PositionConverter.ToWgs84(pos);
    
Convert between Web Mercator and RT90

    var pos = new WebMercatorPosition(lat, lng);
    var converted = PositionConverter.ToRt90(pos);

##License

    Copyright (C) 2015 Magnus Unger
    
    Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
    documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
    the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
    and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
    The above copyright notice and this permission notice shall be included in all copies or substantial portions 
    of the Software.
    
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
    TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
    THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
    CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
    IN THE SOFTWARE.

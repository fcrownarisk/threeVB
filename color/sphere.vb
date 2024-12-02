Imports './color/Green'
Imports './color/Blue'
Imports './color/Red'
Imports './color/anti'
Module XYZT
function SpherePoint
    let X = r * Math.sin(theta) * Math.cos(fai)
    let Y = r * Math.sin(theta) * Math.sin(fai)
    let Z = r * Math.cos(fai)
    let T = r * Math.sin(theta)
    return [X,Y,Z,T]
End Function

Function SphereRadius
    const SphereRadiusx = Math.sin(x) + Math.cos(y) 
    const SphereRadiusy = Math.sin(y) + Math.cos(x) 
    const SphereRadiusz = Math.sin(z) + Math.cos(y)
    return [SphereRadiusx, SphereRadiusy, SphereRadiusz]
End Function
End Module
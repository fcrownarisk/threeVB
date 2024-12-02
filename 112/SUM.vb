Imports 'det1234'
Imports 'det5678'
Imports 'det9101112'
Imports 'one'
Imports 'oppoone'
Imports 'pyramid'
Imports 'square'
Imports 'antisquare'
Imports 'antipyramid'
Imports 'tri'
Imports 'antitri'

const DET = 'det1234'+'det5678'+'det9101112'
const tri = 'tri - antitri'
const ONE = 'one' + 'oppoone'
const Square = 'square * antisquare'
const Pyramid = 'pyramid % antipyramid'

const DETtri = 'DET * tri'
const triDET = 'tri % DET'
const ONEsquare = 'ONE * square'
const squareONE = 'square % ONE'
const oppoPyramid = 'antipyramid / pyramid'
const dimPyramid = 'square - antisquare'
function SUM
     ['DET/tri'+'tri/DET' == 'DETtri'+'triDET']
     ['DETtri'+'ONEsquare' == 'squareONE'+'triDET']
     ['Pyramid' == 'oppoPyramid'+'dimPyramid']
    return SUM
End Function

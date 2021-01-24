module Ingredient

type Ingredient =
    { name : string
    ; qty  : float
    ; unit : string
    ; img  : string }

let ingredients : List Ingredient = 
    [ Ingredient "Tomato" 4 "piece" "img/tomato.jpg"
    , Ingredient "Onion" 1 "piece" "img/onion.jpg"
    , Ingredient "Turkey" 220 "gram" "img/turkey.jpg" ]

// toForm : Ingredient -> Form { img } =
//    Element.image size size img |> Collage.toForm

// addIngredient : (Float, Float) -> Ingredient -> Form -> Form
// addIngredient (col, row) ingredient board =
//     let
//         (dx, dy) = calculateMove(col, row)
//         blockForm = toForm ingredient |> move (dx, dy)
//     in group [board, blockForm]
// 
// emptyIngredient : Form
// emptyIngredient = 
//     let tileSize = toFloat size
//         scale = 0.6
//         scaleMargin = 0.5 * (1-scale)*tileSize
//         transform = Collage.scale scale >> Collage.move (-scaleMargin, scaleMargin/2)
//         square = Collage.outlined (Collage.dashed Color.gray) (Collage.square 100)
//         rect w h = Collage.filled Color.gray (Collage.rect w h)
//         thick = 2
//         cross  = group [ rect 20 thick, rect thick 20 ]
//     in group [square, cross] |> transform
        
// --- Example ingredients
let turkey             = Ingredient "Turkey" 220 "gram" "img/turkey.jpg"
let oliveoil           = Ingredient "Olive Oil" 1 "el" "img/olijfolie.jpg"
let pezo               = Ingredient "Salt & Pepper" 1 "snuifje" "img/pezo.jpg"
let artisjokhart       = Ingredient "Artisjokhart" 3 "stuks" "img/artisjokhart.jpg"
let zongedroogdtomaten = Ingredient "Zongedroogde tomaten" 4 "stuks" "img/zongedroogd-tomaten.jpg"
let littlegem          = Ingredient "Little gem" 1 "kropje" "img/littlegem.jpg"
let macadamia          = Ingredient "Macadamia noten" 1 "handvol" "img/macadamia.jpg"
let rijst              = Ingredient "Rice" 1 "zakje" "img/rice.png"


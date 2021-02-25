namespace FoodFlow.Business

module Library =
    open DomainTypes

    let hello name =
        printfn "Hello %s" name

    let addIngredient ingredient =
        let name = ingredient.name
        printfn "Hello %s" name

    //let addIngredient (col, row) ingredient board
    //    let
    //        (dx, dy) = calculateMove (col, row)

    // --------------------------------------------------------------------------------
    // --------------------------------------------------------------------------------
            // because we want to build a function here that sort of does:
            //  :: Ingredient -> HTML
            // we should research into:
            //  - Fable / Elmish (do it on the frontend JS)
            //  - Giraffe?       (do it on the backend?)
            //  - F# Blazor (Bolero?) (do it on the frontend WASM)


            // Current plan:
            // - create in F# a whole logic for creating Recipes
            // - create in Blazor a whole logic for drawing Recipes / Ingredients / Steps ?
            //          (based on the graphics library from Elm)
    // --------------------------------------------------------------------------------
    // --------------------------------------------------------------------------------








    //toForm : Ingredient -> Form
    //let toForm { img  = img } =
        
    //addIngredient : (Float, Float) -> Ingredient -> Form -> Form
    //addIngredient (col, row) ingredient board =
    //    let
    //        (dx, dy) = calculateMove(col, row)
    //        blockForm = toForm ingredient |> move (dx, dy)
    //    in group [board, blockForm]

//emptyIngredient : Form
//emptyIngredient = 
//    let tileSize = toFloat size
//        scale = 0.6
//        scaleMargin = 0.5 * (1-scale)*tileSize
//        transform = Collage.scale scale >> Collage.move (-scaleMargin, scaleMargin/2)
//        square = Collage.outlined (Collage.dashed Color.gray) (Collage.square 100)
//        rect w h = Collage.filled Color.gray (Collage.rect w h)
//        thick = 2
//        cross  = group [ rect 20 thick, rect thick 20 ]
//    in group [square, cross] |> transform



namespace FoodFlow.Business

module Say =
    let hello name =
        printfn "Hello %s" name

module Ingredient =
    type Ingredient =
        { name : string;
          qty  : float;
          unit : string;
          img  : string;
        }

    let createIngredient name qty unit img =
        { name = name;
          qty = qty;
          unit = unit;
          img = img
        }

    // --- Example ingredients
    let ingredients = 
        [ createIngredient "Tomato" 4. "piece" "img/tomato.jpg";
          createIngredient "Onion" 1. "piece" "img/onion.jpg";
          createIngredient "Salad" 3. "leaves" "img/salad.jpg";
          createIngredient "Turkey" 220. "gram" "img/turkey.jpg";
        ]

    let turkey             = createIngredient "Turkey" 220. "gram" "img/turkey.jpg"
    let oliveoil           = createIngredient "Olive Oil" 1. "el" "img/olijfolie.jpg"
    let pezo               = createIngredient "Salt & Pepper" 1. "snuifje" "img/pezo.jpg"
    let artisjokhart       = createIngredient "Artisjokhart" 3. "stuks" "img/artisjokhart.jpg"
    let zongedroogdtomaten = createIngredient "Zongedroogde tomaten" 4. "stuks" "img/zongedroogd-tomaten.jpg"
    let littlegem          = createIngredient "Little gem" 1. "kropje" "img/littlegem.jpg"
    let macadamia          = createIngredient "Macadamia noten" 1. "handvol" "img/macadamia.jpg"
    let rijst              = createIngredient "Rice" 1. "zakje" "img/rice.png"


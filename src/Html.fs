namespace Feliz

open Fable.React
open Fable.Core
open Fable.Core.JsInterop

[<Erase>]
type Html =
    /// The `<div>` tag defines a division or a section in an HTML document
    static member inline div xs = Interop.createElement "div" xs
    static member inline article xs = Interop.createElement "article" xs
    static member inline aside xs = Interop.createElement "aside" xs
    static member inline footer xs = Interop.createElement "footer" xs
    static member inline progress xs = Interop.createElement "progress" xs
    static member inline nav xs = Interop.createElement "nav" xs
    static member inline label xs = Interop.createElement "label" xs
    static member inline fieldSet xs = Interop.createElement "fieldset" xs
    static member inline section xs = Interop.createElement "section" xs
    static member inline figure xs = Interop.createElement "figure" xs
    static member inline figcaption xs = Interop.createElement "figcaption" xs
    static member inline select xs = Interop.createElement "select" xs
    static member inline option xs = Interop.createElement "select" xs
    static member inline strong xs = Interop.createElement "strong" xs
    static member inline table xs = Interop.createElement "table" xs
    static member inline tbody xs = Interop.createElement "tbody" xs
    static member inline tableBody xs = Html.tbody xs
    static member inline tableRow xs = Interop.createElement "tr" xs
    static member inline tr xs = Interop.createElement "tr" xs
    static member inline tableCell xs = Interop.createElement "td" xs
    static member inline details xs = Interop.createElement "details" xs
    static member inline summary xs = Interop.createElement "summary" xs
    static member inline td xs = Interop.createElement "td" xs
    static member inline th xs = Interop.createElement "th" xs
    static member inline tableHeader xs = Interop.createElement "th" xs
    static member inline tfoot xs = Interop.createElement "tfoot" xs
    static member inline textarea xs = Interop.createElement "textarea" xs
    static member inline video xs = Interop.createElement "video" xs
    static member inline h1 xs = Interop.createElement "h1" xs
    static member inline h2 xs = Interop.createElement "h2" xs
    static member inline h3 xs = Interop.createElement "h3" xs
    static member inline h4 xs = Interop.createElement "h4" xs
    static member inline h5 xs = Interop.createElement "h5" xs
    static member inline h6 xs = Interop.createElement "h6" xs
    static member inline button xs = Interop.createElement "button" xs
    static member inline span xs = Interop.createElement "span" xs
    static member inline li xs = Interop.createElement "li" xs
    static member inline ul xs = Interop.createElement "ul" xs
    static member inline ol xs = Interop.createElement "ol" xs
    static member inline a xs = Interop.createElement "a" xs
    static member inline anchor xs = Interop.createElement "anchor" xs
    static member inline img xs = Interop.createElement "img" xs
    static member inline br xs = Interop.createElement "br" xs
    static member inline hr xs = Interop.createElement "hr" xs
    static member inline input xs = Interop.createElement "input" xs
    static member inline form xs = Interop.createElement "form" xs
    static member inline i xs = Interop.createElement "i" xs
    static member inline p xs = Interop.createElement "p" xs
    static member inline paragraph xs = Interop.createElement "p" xs
    static member inline listItem xs = Interop.createElement "li" xs
    static member inline unorderedList xs = Interop.createElement "ul" xs
    static member inline orderedList xs = Interop.createElement "ul" xs
    static member content (value: string) : ReactElement = unbox value
    static member content (value: int) : ReactElement = unbox value
    static member text (value: string) : ReactElement = unbox value
    static member text (value: int) : ReactElement = unbox value
    static member inline div (value: string) = Interop.reactElement "div" (createObj [ "children" ==> [| value |] ])
    static member inline div (value: int)  = Interop.reactElement "div" (createObj [ "children" ==> [| value |] ])
    static member inline span (value: string) = Interop.reactElement "span" (createObj [ "children" ==> [| value |] ])
    static member inline span (value: int)  = Interop.reactElement "span" (createObj [ "children" ==> [| value |] ])
    static member inline h1 (value: string)  = Interop.reactElement "h1" (createObj [ "children" ==> [| value |] ])
    static member inline h1 (value: int)  = Interop.reactElement "h1" (createObj [ "children" ==> [| value |] ])
    static member inline h2 (value: string)  =  Interop.reactElement "h2" (createObj [ "children" ==> [| value |] ])
    static member inline h2 (value: int)  =  Interop.reactElement "h2" (createObj [ "children" ==> [| value |] ])
    static member inline h3 (value: string)  =  Interop.reactElement "h3" (createObj [ "children" ==> [| value |] ])
    static member inline h3 (value: int)  =  Interop.reactElement "h3" (createObj [ "children" ==> [| value |] ])
    static member inline h4 (value: string)  = Interop.reactElement "h4" (createObj [ "children" ==> [| value |] ])
    static member inline h4 (value: int)  = Interop.reactElement "h4" (createObj [ "children" ==> [| value |] ])
    static member inline h5 (value: string)  = Interop.reactElement "h5" (createObj [ "children" ==> [| value |] ])
    static member inline h5 (value: int)  = Interop.reactElement "h5" (createObj [ "children" ==> [| value |] ])
    static member inline h6 (value: string)  = Interop.reactElement "h6" (createObj [ "children" ==> [| value |] ])
    static member inline h6 (value: int) = Interop.reactElement "h6" (createObj [ "children" ==> [| value |] ])
    static member inline strong(value: string)  = Interop.reactElement "strong" (createObj [ "children" ==> [| value |] ])
    static member inline strong(value: int) = Interop.reactElement "strong" (createObj [ "children" ==> [| value |] ])
    static member inline p(value: string) = Interop.reactElement "p" (createObj [ "children" ==> [| value |] ])
    static member inline p(value: int) = Interop.reactElement "p" (createObj [ "children" ==> [| value |] ])
    static member inline paragraph(value: string)  = Interop.reactElement "p" (createObj [ "children" ==> [| value |] ])
    static member inline paragraph(value: int)  = Interop.reactElement "p" (createObj [ "children" ==> [| value |] ])
    static member inline td(value: string) = Interop.reactElement "td" (createObj [ "children" ==> [| value |] ])
    static member inline td(value: int)  = Interop.reactElement "td" (createObj [ "children" ==> [| value |] ])
    static member inline th(value: string)  = Interop.reactElement "th" (createObj [ "children" ==> [| value |] ])
    static member inline th(value: int)  = Interop.reactElement "th" (createObj [ "children" ==> [| value |] ])
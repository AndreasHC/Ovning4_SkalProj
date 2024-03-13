Språkkommentar: Google har "Ungefär 3 380 resultat" för "som namnet föreslår", och "Ungefär 453 000 resultat" för "som namnet antyder". Pris-ske-Gud-i-hallonlandet.

Terminologikommentar: Påståendet "En pointer skiljer sig från reference types, i det avseendet att när något är av en reference type, så kommer vi åt det via en pointer" känns inte som en bra början på en terminologi som gör vederbörlig åtskillnad på referenser, referensernas referenter, pekare av det slag som beskrivs i https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/pointer-related-operators och pekarnas referenter.

## Svar på fråga 1
En stack innehåller de data (av värdetyp, och referenser, men inte referensernas referenter) som hör till de pågående metodinstanserna i den tråd som stacken är förknippad med. Varje gång en ny metodinstans påbörjas travas ett nytt minnesavsnitt för den metodinstansen på stackens topp, och när metodinstansen har avslutats behandlas det minnet som tillgängligt för en ny metodinstans.

Heapen innehåller objektinstanser. Det finns ingen väldefinierad ordning, materialet läggs till där det finns utrymme, och tas bort när det befinns vara onödigt.

## Svar på fråga 2
Värdetyper kan existera inom en metodinstans, eller inom en objektinstans. Referenstyper kan bara existera på heapen. Metodinstanser och objektinstanser kan bara ha referenser till dem.

## Svar på fråga 3
int är en värdetyp, så när x och y är int så innebär "y = x" att heltalsvärdet lagrat i x kopieras till y, och att vad som vidare händer med y inte påverkar x.

MyInt är däremot en referenstyp, så när x och y är MyInt så är "y = x" en instruktion avseende referenserna själva, närmare bestämt en instruktion att kopiera referensen i x till y, men "y.MyValue = 4" är en instruktion avseende referensen y:s referent, som också i detta läge är referensen x:s referent, så värdet av uttrycket "x.MyValue" ändras.

### Kommentar
Jag visste inte att "new int()" gick. Är det någonsin en bra idé?

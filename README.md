﻿Språkkommentar: Google har "Ungefär 3 380 resultat" för "som namnet föreslår", och "Ungefär 453 000 resultat" för "som namnet antyder". Pris-ske-Gud-i-hallonlandet.

Terminologikommentar: Påståendet "En pointer skiljer sig från reference types, i det avseendet att när något är av en reference type, så kommer vi åt det via en pointer" känns inte som en bra början på en terminologi som gör vederbörlig åtskillnad på referenser, referensernas referenter, pekare av det slag som beskrivs i https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/pointer-related-operators och pekarnas referenter.

Terminologikommentar 2: Säger man "metodinstanser"? Det känns absolut nödvändigt att tala om "metodinstanser" i svaren på de här frågorna.

## Svar på fråga 1
En stack innehåller de data (av värdetyp, och referenser, men inte referensernas referenter) som hör till de pågående metodinstanserna i den tråd som stacken är förknippad med. Varje gång en ny metodinstans påbörjas travas ett nytt minnesavsnitt för den metodinstansen på stackens topp, och när metodinstansen har avslutats behandlas det minnet som tillgängligt för en ny metodinstans.

Heapen innehåller referensernas referenter, såsom arrayer och objektinstanser. Det finns ingen väldefinierad ordning, materialet läggs till där det finns utrymme, och tas bort när det befinns vara onödigt. Referenser och material av värdetyp uppträder normalt bara på heapen som en del av någonting större.

## Svar på fråga 2
En variabel eller ett fält av värdetyp svarar mot ett minnesutrymme inom det utrymme som är avsatt för till exempel en metodinstans eller objektinstans, och detta utrymme innehåller allt det data som är förknippat med variabeln. En variabel eller ett fält av referenstyp har en referent utanför det utrymme som är det omgivande kontextets utrymme, och det material som finns innanför detta kontext är bara det som är nödvändigt för att hitta denna referent, medan huvuddelen av det data som är förknippat med variabeln/fältet återfinns i referenten.

## Svar på fråga 3
int är en värdetyp, så när x och y är int så innebär "y = x" att heltalsvärdet lagrat i x kopieras till y, och att vad som vidare händer med y inte påverkar x.

MyInt är däremot en referenstyp, så när x och y är MyInt så är "y = x" en instruktion avseende referenserna själva, närmare bestämt en instruktion att kopiera referensen i x till y, men "y.MyValue = 4" är en instruktion avseende referensen y:s referent, som också i detta läge är referensen x:s referent, så värdet av uttrycket "x.MyValue" ändras.

### Kommentar
Jag fick inte fullt klart för mig att CS0165-felens existens innebär att default-värden för värdetyper i praktiken bara är tillämpliga på objektfält, och att lokala variabler i metoder faktiskt måste instantieras explicit, förrän jag försökte begripa varför kompilatorn över huvud taget accepterade "new int()".

## Pappersdelen av övning 2
a.      ICA öppnar och kön till kassan är tom 
[]
b.      Kalle ställer sig i kön 
[Kalle]
c.      Greta ställer sig i kön 
[Kalle, Greta]
d.      Kalle blir expedierad och lämnar kön 
[Greta]
e.      Stina ställer sig i kön 
[Greta, Stina]
f.      Greta blir expedierad och lämnar kön 
[Stina]
g.      Olle ställer sig i kön
[Stina, Olle]
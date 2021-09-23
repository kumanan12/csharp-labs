string pangram = "The quick brown fox jumps over the lazy dog";
ehT kciuq nworb xof spmuj revo eht yzal god

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
B123
B177
B179

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters 
// we want to look for:

char[] openSymbols = { '[', '{', '(' };

// We'll use a slightly different technique for iterating through the 
// characters in the string.  This time, we'll use the closing position
// of the previous iteration as the starting index for the next open
// symbol.  So, we need to initialize the closingPosition variable
// to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now we must find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // Finally, use the techniques we've already learned to display the sub-string:

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}

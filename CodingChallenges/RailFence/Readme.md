Challenge

The rail fence cipher (sometimes called a zigzag cipher) is a form of transposition cipher. It derives its name from the way it is encoded.

In the rail fence cipher, the plain text is written downwards and diagonally on successive rails of an imaginary fence, then moving up when the bottom of the rail is reached. When the top rail is reached, the message is written downwards again until the whole plaintext is written out. The message is then read off in rows. For example, if there are 3 “rails” and the message is “WE ARE DISCOVERED FLEE AT ONCE“ is used, the cipher writes out:


W . . . E . . . C . . . R . . . L . . . T . . . E

. E . R . D . S . O . E . E . F . E . A . O . C .

. . A . . . I . . . V . . . D . . . E . . . N . .

Then it is read off to get the cipher text:


WECRLTEERDSOEEFEAOCAIVDEN

Note that this particular example does NOT use spaces separating the words. The decipherer will need to add them based on context.

Keys can also be used in this cipher e.g. In this example shown above we have a key=3 which means there are three rails, or three lines of text.

Requirements
Create 2 methods:


encode(int key, string plainText) // => Returns an encoded string
decode(int key, string encodedText) // => Returns the decoded string

Notes
Spaces should be removed from any plainText messages passed into the encode method.

Examples

encode(4, "THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG") // => TCNMRZHIKWFUPETAYEUBOOJSVHLDGQRXOEO

decode(4, "TCNMRZHIKWFUPETAYEUBOOJSVHLDGQRXOEO") // => THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG

Tests

encode(2, "I HAVE SPACES")

encode(3, "I_REALLY_LIKE_PUZZLES!")

encode(30, "THISISNOTAVERYGOODSECRETCODE")

decode(8, "WGENCLIHODAVOLSECLETEEGHN")

decode(7, "384874021.5963843594466817137232191456280204596809907918934616343573592869437522829198037288593762002")

Feel free to attempt the challenge in any language, and use the comments to post your solutions/code snippets or discuss the challenge.
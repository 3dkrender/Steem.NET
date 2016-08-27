# Steem.NET

.NET classes to interact with the STEEM blockchain.

## Prerequisites

1. Steemd 

To communicate with **steemd** you need a local steemd running node with  rpc-endpoint open
By default, CSteemd object will try to connect to host **"127.0.0.1:8090"**

check [Steem Windows mining guide](https://steemit.com/steem/@bitcube/steem-mining-in-microsoft-windows-a-miner-s-guide-part-2) for more information on how to do it.
You don't need to mine effectively, a simple syncing node is OK

2. cli_wallet
 
To communicate with **cli-wallet** you need a local cli_wallet running node with  rpc-endpoint open
By default, CSteemd object will try to connect to host **"127.0.0.1:8091"**

## Quick-Start

###Using Steem.NET COM library
Steem.NET API is precompiled in a DLL. 
Download an copy the following files to any directory that fit your needs :
```
StemAPI.dll
Newtonsoft.Json.dll
```
Add it to any project or use it in anny application able to dialog with COM objects (Words, Excel, ...)

###Using Microsoft Visual Studio VB.NET classes
Create a VB.NET project and add following classes :
```
CJson.vb
CSteemAPI.vb
CSteemd.vb
CSteemWallet.vb
```

If you don't have Json.NET from Newtonsoft installed, simply add the provided Newtonsoft.Json.dll to you project references

That's it ! You're nowready to communicate with your local  node 

## Remark

The class library is quite 'read-lony' at the moment but shats a good start to browse any information in the blockchain.
I still have to implement posts, upvotes and comment

## IMPORTANT NOTE

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.

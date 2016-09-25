# Steem.NET

Microsoft C#.NET classes to interact with the STEEM blockchain.

###Using Microsoft Visual Studio VB.NET classes
Create a VB.NET project and add following classes :
```
CJson.cs
CSteemAPI.cs
CSteemd.cs
CSteemWallet.cs
CWebSocket.cs
```

If you don't have Json.NET from Newtonsoft installed, simply add the provided Newtonsoft.Json.dll to you project references

That's it ! You're nowready to communicate with any steem node, either local or remote 

## Remark
**CSteemd** class exposes all steemd API (used to browse blockchain information)

**CSteemWallet** class exposes all cli_wallet API (used to interact with blockchain with posts, comments, votes, ...) 

## IMPORTANT NOTE

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.

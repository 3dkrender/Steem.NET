# Steem.NET

.NET classes to interact with the STEEM blockchain.

## Prerequisites

You have to have a local steemd running node
check [Steem Windows mining guide](https://steemit.com/steem/@bitcube/steem-mining-in-microsoft-windows-a-miner-s-guide-part-2) for more information on how to do it.

Your node must have rpc-endpoint listening to 127.0.0.1:8090.

You don't need to mine effectively, a simple syncing node is OK

## Quick-Start
Create a VB.NET project and add both classes
```
CJson.vb
CSteemAPI.vb
```

If you don't have Json.NET from Newtonsoft installed, simply add the provided Newtonsoft.Json.dll to you project references

That's it ! You're nowready to communicate with your local  node 

# IMPORTANT NOTE

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.

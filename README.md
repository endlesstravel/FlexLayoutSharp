
# FlexLayoutSharp

C# implementation of [flexbox CSS](https://www.w3.org/TR/css-flexbox-1/) layout algorithm. Adapt from https://github.com/kjk/flex

Thanks [kjk/flex](https://github.com/kjk/flex), there is no such project without him.

Nuget Package [FlexLayoutSharp](https://www.nuget.org/packages/FlexLayoutSharp/) :

`Install-Package FlexLayoutSharp`
 
## Usage

more example please check [test file](RockyfiTests/Rockyfi.test.cs)


```C#
var root = Flex.CreateDefaultNode();
root.StyleSetWidth(100);
root.StyleSetHeight(100);

var rootChild0 = Flex.CreateDefaultNode();
rootChild0.StyleSetPositionType(PositionType.Absolute);
rootChild0.StyleSetPosition(Edge.Start, 10);
rootChild0.StyleSetPosition(Edge.Top, 10);
rootChild0.StyleSetWidth(10);
rootChild0.StyleSetHeight(10);
root.InsertChild(rootChild0, 0);
Flex.CalculateLayout(root, float.NaN, float.NaN, Direction.LTR);

assertFloatEqual(0, root.LayoutGetLeft());
assertFloatEqual(0, root.LayoutGetTop());
assertFloatEqual(100, root.LayoutGetWidth());
assertFloatEqual(100, root.LayoutGetHeight());

assertFloatEqual(10, rootChild0.LayoutGetLeft());
assertFloatEqual(10, rootChild0.LayoutGetTop());
assertFloatEqual(10, rootChild0.LayoutGetWidth());
assertFloatEqual(10, rootChild0.LayoutGetHeight());

Console.WriteLine(NodePrinter.PrintToString(root));
```
output is:

```html
<div layout="width: 100; height: 100; top: 0; left: 0;" style="width: 100px; height: 100px; ">
  <div layout="width: 10; height: 10; top: 10; left: 10;" style="width: 10px; height: 10px; position: absolute; top: 10px; "></div>
</div>
```
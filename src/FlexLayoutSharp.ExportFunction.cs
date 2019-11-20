﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexLayoutSharp
{
    public partial class Node
    {
        public void CopyStyle(Node other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            Style.Copy(this.nodeStyle, other.nodeStyle);
        }

        public void MarkAsDirty()
        {
            Flex.nodeMarkDirtyInternal(this);
        }

        #region Style
        // StyleSetWidth sets width
        public void StyleSetWidth(float width)
        {
            var dim = this.nodeStyle.Dimensions[(int)Dimension.Width];
            if (dim.value != width || dim.unit != Unit.Point)
            {
                dim.value = width;
                dim.unit = Unit.Point;
                if (Flex.FloatIsUndefined(width))
                {
                    dim.unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetWidthPercent sets width percent
        public void StyleSetWidthPercent(float width)
        {
            var dim = this.nodeStyle.Dimensions[(int)Dimension.Width];
            if (dim.value != width || dim.unit != Unit.Percent)
            {
                dim.value = width;
                dim.unit = Unit.Percent;
                if (Flex.FloatIsUndefined(width))
                {
                    dim.unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetWidthAuto sets width auto
        public void StyleSetWidthAuto()
        {
            var dim = this.nodeStyle.Dimensions[(int)Dimension.Width];
            if (dim.unit != Unit.Auto)
            {
                dim.value = float.NaN;
                dim.unit = Unit.Auto;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetWidth gets width
        public Value StyleGetWidth()
        {
            return this.nodeStyle.Dimensions[(int)Dimension.Width];
        }

        // StyleSetHeight sets height
        public void StyleSetHeight(float height)
        {
            var dim = this.nodeStyle.Dimensions[(int)Dimension.Height];
            if (dim.value != height || dim.unit != Unit.Point)
            {
                dim.value = height;
                dim.unit = Unit.Point;
                if (Flex.FloatIsUndefined(height))
                {
                    dim.unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetHeightPercent sets height percent
        public void StyleSetHeightPercent(float height)
        {
            var dim = this.nodeStyle.Dimensions[(int)Dimension.Height];
            if (dim.value != height || dim.unit != Unit.Percent)
            {
                dim.value = height;
                dim.unit = Unit.Percent;
                if (Flex.FloatIsUndefined(height))
                {
                    dim.unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetHeightAuto sets height auto
        public void StyleSetHeightAuto()
        {
            var dim = this.nodeStyle.Dimensions[(int)Dimension.Height];
            if (dim.unit != Unit.Auto)
            {
                dim.value = float.NaN;
                dim.unit = Unit.Auto;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetHeight gets height
        public Value StyleGetHeight()
        {
            return this.nodeStyle.Dimensions[(int)Dimension.Height];
        }

        // StyleSetPositionType sets position type
        public void StyleSetPositionType(PositionType positionType)
        {
            if (this.nodeStyle.PositionType != positionType)
            {
                this.nodeStyle.PositionType = positionType;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public PositionType StyleGetPositionType()
        {
            return this.nodeStyle.PositionType;
        }

        // StyleSetPosition sets position
        public void StyleSetPosition(Edge edge, float position)
        {
            var pos = this.nodeStyle.Position[(int)edge];
            if (pos.value != position || pos.unit != Unit.Point)
            {
                pos.value = position;
                pos.unit = Unit.Point;
                if (Flex.FloatIsUndefined(position))
                {
                    pos.unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetPositionPercent sets position percent
        public void StyleSetPositionPercent(Edge edge, float position)
        {
            var pos = this.nodeStyle.Position[(int)edge];
            if (pos.value != position || pos.unit != Unit.Percent)
            {
                pos.value = position;
                pos.unit = Unit.Percent;
                if (Flex.FloatIsUndefined(position))
                {
                    pos.unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetPosition gets position
        public Value StyleGetPosition(Edge edge)
        {
            return this.nodeStyle.Position[(int)edge];
        }

        // StyleSetDirection sets direction
        public void StyleSetDirection(Direction direction)
        {
            if (this.nodeStyle.Direction != direction)
            {
                this.nodeStyle.Direction = direction;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Direction StyleGetDirection()
        {
            return this.nodeStyle.Direction;
        }

        // StyleSetFlexDirection sets flex directions
        public void StyleSetFlexDirection(FlexDirection flexDirection)
        {
            if (this.nodeStyle.FlexDirection != flexDirection)
            {
                this.nodeStyle.FlexDirection = flexDirection;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public FlexDirection StyleGetFlexDirection()
        {
            return this.nodeStyle.FlexDirection;
        }

        // StyleSetJustifyContent sets justify content
        public void StyleSetJustifyContent(Justify justifyContent)
        {
            if (this.nodeStyle.JustifyContent != justifyContent)
            {
                this.nodeStyle.JustifyContent = justifyContent;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Justify StyleGetJustifyContent()
        {
            return this.nodeStyle.JustifyContent;
        }

        // StyleSetAlignContent sets align content
        public void StyleSetAlignContent(Align alignContent)
        {
            if (this.nodeStyle.AlignContent != alignContent)
            {
                this.nodeStyle.AlignContent = alignContent;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Align StyleGetAlignContent()
        {
            return this.nodeStyle.AlignContent;
        }

        // StyleSetAlignItems sets align content
        public void StyleSetAlignItems(Align alignItems)
        {
            if (this.nodeStyle.AlignItems != alignItems)
            {
                this.nodeStyle.AlignItems = alignItems;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Align StyleGetAlignItems()
        {
            return this.nodeStyle.AlignItems;
        }

        // StyleSetAlignSelf sets align self
        public void StyleSetAlignSelf(Align alignSelf)
        {
            if (this.nodeStyle.AlignSelf != alignSelf)
            {
                this.nodeStyle.AlignSelf = alignSelf;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Align StyleGetAlignSelf()
        {
            return this.nodeStyle.AlignSelf;
        }

        // StyleSetFlexWrap sets flex wrap
        public void StyleSetFlexWrap(Wrap flexWrap)
        {
            if (this.nodeStyle.FlexWrap != flexWrap)
            {
                this.nodeStyle.FlexWrap = flexWrap;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Wrap StyleGetFlexWrap()
        {
            return this.nodeStyle.FlexWrap;
        }

        // StyleSetOverflow sets overflow
        public void StyleSetOverflow(Overflow overflow)
        {
            if (this.nodeStyle.Overflow != overflow)
            {
                this.nodeStyle.Overflow = overflow;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Overflow StyleGetOverflow()
        {
            return this.nodeStyle.Overflow;
        }

        // StyleSetDisplay sets display
        public void StyleSetDisplay(Display display)
        {
            if (this.nodeStyle.Display != display)
            {
                this.nodeStyle.Display = display;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Display StyleGetDisplay()
        {
            return this.nodeStyle.Display;
        }

        // StyleSetFlex sets flex
        public void StyleSetFlex(float flex)
        {
            if (this.nodeStyle.Flex != flex)
            {
                this.nodeStyle.Flex = flex;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public float StyleGetFlex()
        {
            return this.nodeStyle.Flex;
        }

        // StyleSetFlexGrow sets flex grow
        public void StyleSetFlexGrow(float flexGrow)
        {
            if (this.nodeStyle.FlexGrow != flexGrow)
            {
                this.nodeStyle.FlexGrow = flexGrow;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetFlexGrow gets flex grow
        public float StyleGetFlexGrow()
        {
            if (float.IsNaN(this.nodeStyle.FlexGrow))
            {
                return Constant.defaultFlexGrow;
            }
            return this.nodeStyle.FlexGrow;
        }

        // StyleGetFlexShrink gets flex shrink
        public float StyleGetFlexShrink()
        {
            if (float.IsNaN(this.nodeStyle.FlexShrink))
            {
                if (this.config.UseWebDefaults)
                {
                    return Constant.webDefaultFlexShrink;
                }
                return Constant.defaultFlexShrink;
            }
            return this.nodeStyle.FlexShrink;
        }

        // StyleSetFlexShrink sets flex shrink
        public void StyleSetFlexShrink(float flexShrink)
        {
            if (this.nodeStyle.FlexShrink != flexShrink)
            {
                this.nodeStyle.FlexShrink = flexShrink;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetFlexBasis sets flex basis
        public void StyleSetFlexBasis(float flexBasis)
        {
            if (this.nodeStyle.FlexBasis.value != flexBasis ||
                this.nodeStyle.FlexBasis.unit != Unit.Point)
            {
                this.nodeStyle.FlexBasis.value = flexBasis;
                this.nodeStyle.FlexBasis.unit = Unit.Point;
                if (Flex.FloatIsUndefined(flexBasis))
                {
                    this.nodeStyle.FlexBasis.unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetFlexBasisPercent sets flex basis percent
        public void StyleSetFlexBasisPercent(float flexBasis)
        {
            if (this.nodeStyle.FlexBasis.value != flexBasis ||
                this.nodeStyle.FlexBasis.unit != Unit.Percent)
            {
                this.nodeStyle.FlexBasis.value = flexBasis;
                this.nodeStyle.FlexBasis.unit = Unit.Percent;
                if (Flex.FloatIsUndefined(flexBasis))
                {
                    this.nodeStyle.FlexBasis.unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // NodeStyleSetFlexBasisAuto sets flex basis auto
        public void NodeStyleSetFlexBasisAuto()
        {
            if (this.nodeStyle.FlexBasis.unit != Unit.Auto)
            {
                this.nodeStyle.FlexBasis.value = float.NaN;
                this.nodeStyle.FlexBasis.unit = Unit.Auto;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        public Value NodeStyleGetFlexBasis()
        {
            return this.nodeStyle.FlexBasis;
        }

        // StyleSetMargin sets margin
        public void StyleSetMargin(Edge edge, float margin)
        {
            if (this.nodeStyle.Margin[(int)edge].value != margin ||
                this.nodeStyle.Margin[(int)edge].unit != Unit.Point)
            {
                this.nodeStyle.Margin[(int)edge].value = margin;
                this.nodeStyle.Margin[(int)edge].unit = Unit.Point;
                if (Flex.FloatIsUndefined(margin))
                {
                    this.nodeStyle.Margin[(int)edge].unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetMarginPercent sets margin percent
        public void StyleSetMarginPercent(Edge edge, float margin)
        {
            if (this.nodeStyle.Margin[(int)edge].value != margin ||
                this.nodeStyle.Margin[(int)edge].unit != Unit.Percent)
            {
                this.nodeStyle.Margin[(int)edge].value = margin;
                this.nodeStyle.Margin[(int)edge].unit = Unit.Percent;
                if (Flex.FloatIsUndefined(margin))
                {
                    this.nodeStyle.Margin[(int)edge].unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetMargin gets margin
        public Value StyleGetMargin(Edge edge)
        {
            return this.nodeStyle.Margin[(int)edge];
        }

        // StyleSetMarginAuto sets margin auto
        public void StyleSetMarginAuto(Edge edge)
        {
            if (this.nodeStyle.Margin[(int)edge].unit != Unit.Auto)
            {
                this.nodeStyle.Margin[(int)edge].value = float.NaN;
                this.nodeStyle.Margin[(int)edge].unit = Unit.Auto;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetPadding sets padding
        public void StyleSetPadding(Edge edge, float padding)
        {
            if (this.nodeStyle.Padding[(int)edge].value != padding ||
                this.nodeStyle.Padding[(int)edge].unit != Unit.Point)
            {
                this.nodeStyle.Padding[(int)edge].value = padding;
                this.nodeStyle.Padding[(int)edge].unit = Unit.Point;
                if (Flex.FloatIsUndefined(padding))
                {
                    this.nodeStyle.Padding[(int)edge].unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetPaddingPercent sets padding percent
        public void StyleSetPaddingPercent(Edge edge, float padding)
        {
            if (this.nodeStyle.Padding[(int)edge].value != padding ||
                this.nodeStyle.Padding[(int)edge].unit != Unit.Percent)
            {
                this.nodeStyle.Padding[(int)edge].value = padding;
                this.nodeStyle.Padding[(int)edge].unit = Unit.Percent;
                if (Flex.FloatIsUndefined(padding))
                {
                    this.nodeStyle.Padding[(int)edge].unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetPadding gets padding
        public Value StyleGetPadding(Edge edge)
        {
            return this.nodeStyle.Padding[(int)edge];
        }

        // StyleSetBorder sets border
        public void StyleSetBorder(Edge edge, float border)
        {
            if (this.nodeStyle.Border[(int)edge].value != border ||
                this.nodeStyle.Border[(int)edge].unit != Unit.Point)
            {
                this.nodeStyle.Border[(int)edge].value = border;
                this.nodeStyle.Border[(int)edge].unit = Unit.Point;
                if (Flex.FloatIsUndefined(border))
                {
                    this.nodeStyle.Border[(int)edge].unit = Unit.Undefined;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetBorder gets border
        public float StyleGetBorder(Edge edge)
        {
            return this.nodeStyle.Border[(int)edge].value;
        }

        // StyleSetMinWidth sets min width
        public void StyleSetMinWidth(float minWidth)
        {
            if (this.nodeStyle.MinDimensions[(int)Dimension.Width].value != minWidth ||
                this.nodeStyle.MinDimensions[(int)Dimension.Width].unit != Unit.Point)
            {
                this.nodeStyle.MinDimensions[(int)Dimension.Width].value = minWidth;
                this.nodeStyle.MinDimensions[(int)Dimension.Width].unit = Unit.Point;
                if (Flex.FloatIsUndefined(minWidth))
                {
                    this.nodeStyle.MinDimensions[(int)Dimension.Width].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetMinWidthPercent sets width percent
        public void StyleSetMinWidthPercent(float minWidth)
        {
            if (this.nodeStyle.MinDimensions[(int)Dimension.Width].value != minWidth ||
                this.nodeStyle.MinDimensions[(int)Dimension.Width].unit != Unit.Percent)
            {
                this.nodeStyle.MinDimensions[(int)Dimension.Width].value = minWidth;
                this.nodeStyle.MinDimensions[(int)Dimension.Width].unit = Unit.Percent;
                if (Flex.FloatIsUndefined(minWidth))
                {
                    this.nodeStyle.MinDimensions[(int)Dimension.Width].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetMinWidth gets min width
        public Value StyleGetMinWidth()
        {
            return this.nodeStyle.MinDimensions[(int)Dimension.Width];
        }

        // StyleSetMinHeight sets min width
        public void StyleSetMinHeight(float minHeight)
        {
            if (this.nodeStyle.MinDimensions[(int)Dimension.Height].value != minHeight ||
                this.nodeStyle.MinDimensions[(int)Dimension.Height].unit != Unit.Point)
            {
                this.nodeStyle.MinDimensions[(int)Dimension.Height].value = minHeight;
                this.nodeStyle.MinDimensions[(int)Dimension.Height].unit = Unit.Point;
                if (Flex.FloatIsUndefined(minHeight))
                {
                    this.nodeStyle.MinDimensions[(int)Dimension.Height].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetMinHeightPercent sets min height percent
        public void StyleSetMinHeightPercent(float minHeight)
        {
            if (this.nodeStyle.MinDimensions[(int)Dimension.Height].value != minHeight ||
                this.nodeStyle.MinDimensions[(int)Dimension.Height].unit != Unit.Percent)
            {
                this.nodeStyle.MinDimensions[(int)Dimension.Height].value = minHeight;
                this.nodeStyle.MinDimensions[(int)Dimension.Height].unit = Unit.Percent;
                if (Flex.FloatIsUndefined(minHeight))
                {
                    this.nodeStyle.MinDimensions[(int)Dimension.Height].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetMinHeight gets min height
        public Value StyleGetMinHeight()
        {
            return this.nodeStyle.MinDimensions[(int)Dimension.Height];
        }

        // StyleSetMaxWidth sets max width
        public void StyleSetMaxWidth(float maxWidth)
        {
            if (this.nodeStyle.MaxDimensions[(int)Dimension.Width].value != maxWidth ||
                this.nodeStyle.MaxDimensions[(int)Dimension.Width].unit != Unit.Point)
            {
                this.nodeStyle.MaxDimensions[(int)Dimension.Width].value = maxWidth;
                this.nodeStyle.MaxDimensions[(int)Dimension.Width].unit = Unit.Point;
                if (Flex.FloatIsUndefined(maxWidth))
                {
                    this.nodeStyle.MaxDimensions[(int)Dimension.Width].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetMaxWidthPercent sets max width percent
        public void StyleSetMaxWidthPercent(float maxWidth)
        {
            if (this.nodeStyle.MaxDimensions[(int)Dimension.Width].value != maxWidth ||
                this.nodeStyle.MaxDimensions[(int)Dimension.Width].unit != Unit.Percent)
            {
                this.nodeStyle.MaxDimensions[(int)Dimension.Width].value = maxWidth;
                this.nodeStyle.MaxDimensions[(int)Dimension.Width].unit = Unit.Percent;
                if (Flex.FloatIsUndefined(maxWidth))
                {
                    this.nodeStyle.MaxDimensions[(int)Dimension.Width].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetMaxWidth gets max width
        public Value StyleGetMaxWidth()
        {
            return this.nodeStyle.MaxDimensions[(int)Dimension.Width];
        }

        // StyleSetMaxHeight sets max width
        public void StyleSetMaxHeight(float maxHeight)
        {
            if (this.nodeStyle.MaxDimensions[(int)Dimension.Height].value != maxHeight ||
                this.nodeStyle.MaxDimensions[(int)Dimension.Height].unit != Unit.Point)
            {
                this.nodeStyle.MaxDimensions[(int)Dimension.Height].value = maxHeight;
                this.nodeStyle.MaxDimensions[(int)Dimension.Height].unit = Unit.Point;
                if (Flex.FloatIsUndefined(maxHeight))
                {
                    this.nodeStyle.MaxDimensions[(int)Dimension.Height].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleSetMaxHeightPercent sets max height percent
        public void StyleSetMaxHeightPercent(float maxHeight)
        {
            if (this.nodeStyle.MaxDimensions[(int)Dimension.Height].value != maxHeight ||
                this.nodeStyle.MaxDimensions[(int)Dimension.Height].unit != Unit.Percent)
            {
                this.nodeStyle.MaxDimensions[(int)Dimension.Height].value = maxHeight;
                this.nodeStyle.MaxDimensions[(int)Dimension.Height].unit = Unit.Percent;
                if (Flex.FloatIsUndefined(maxHeight))
                {
                    this.nodeStyle.MaxDimensions[(int)Dimension.Height].unit = Unit.Auto;
                }
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // StyleGetMaxHeight gets max height
        public Value StyleGetMaxHeight()
        {
            return this.nodeStyle.MaxDimensions[(int)Dimension.Height];
        }

        // StyleSetAspectRatio sets axpect ratio
        public void StyleSetAspectRatio(float aspectRatio)
        {
            if (this.nodeStyle.AspectRatio != aspectRatio)
            {
                this.nodeStyle.AspectRatio = aspectRatio;
                Flex.nodeMarkDirtyInternal(this);
            }
        }

        // LayoutGetLeft gets left
        public float LayoutGetLeft()
        {
            return this.nodeLayout.Position[(int)Edge.Left];
        }

        // LayoutGetTop gets top
        public float LayoutGetTop()
        {
            return this.nodeLayout.Position[(int)Edge.Top];
        }

        // LayoutGetRight gets right
        public float LayoutGetRight()
        {
            return this.nodeLayout.Position[(int)Edge.Right];
        }

        // LayoutGetBottom gets bottom
        public float LayoutGetBottom()
        {
            return this.nodeLayout.Position[(int)Edge.Bottom];
        }

        // LayoutGetWidth gets width
        public float LayoutGetWidth()
        {
            return this.nodeLayout.Dimensions[(int)Dimension.Width];
        }

        // LayoutGetHeight gets height
        public float LayoutGetHeight()
        {
            return this.nodeLayout.Dimensions[(int)Dimension.Height];
        }

        // LayoutGetMargin gets margin
        public float LayoutGetMargin(Edge edge)
        {
            Flex.assertWithNode(this, edge < Edge.End, "Cannot get layout properties of multi-edge shorthands");
            if (edge == Edge.Left)
            {
                if (this.nodeLayout.Direction == Direction.RTL)
                {
                    return this.nodeLayout.Margin[(int)Edge.End];
                }
                return this.nodeLayout.Margin[(int)Edge.Start];
            }
            if (edge == Edge.Right)
            {
                if (this.nodeLayout.Direction == Direction.RTL)
                {
                    return this.nodeLayout.Margin[(int)Edge.Start];
                }
                return this.nodeLayout.Margin[(int)Edge.End];
            }
            return this.nodeLayout.Margin[(int)edge];
        }

        // LayoutGetBorder gets border
        public float LayoutGetBorder(Edge edge)
        {
            Flex.assertWithNode(this, edge < Edge.End,
                "Cannot get layout properties of multi-edge shorthands");
            if (edge == Edge.Left)
            {
                if (this.nodeLayout.Direction == Direction.RTL)
                {
                    return this.nodeLayout.Border[(int)Edge.End];
                }
                return this.nodeLayout.Border[(int)Edge.Start];
            }
            if (edge == Edge.Right)
            {
                if (this.nodeLayout.Direction == Direction.RTL)
                {
                    return this.nodeLayout.Border[(int)Edge.Start];
                }
                return this.nodeLayout.Border[(int)Edge.End];
            }
            return this.nodeLayout.Border[(int)edge];
        }

        // LayoutGetPadding gets padding
        public float LayoutGetPadding(Edge edge)
        {
            Flex.assertWithNode(this, edge < Edge.End,
                "Cannot get layout properties of multi-edge shorthands");
            if (edge == Edge.Left)
            {
                if (this.nodeLayout.Direction == Direction.RTL)
                {
                    return this.nodeLayout.Padding[(int)Edge.End];
                }
                return this.nodeLayout.Padding[(int)Edge.Start];
            }
            if (edge == Edge.Right)
            {
                if (this.nodeLayout.Direction == Direction.RTL)
                {
                    return this.nodeLayout.Padding[(int)Edge.Start];
                }
                return this.nodeLayout.Padding[(int)Edge.End];
            }
            return this.nodeLayout.Padding[(int)edge];
        }

        public Direction LayoutGetDirection()
        {
            return this.nodeLayout.Direction;
        }

        public bool LayoutGetHadOverflow()
        {
            return this.nodeLayout.HadOverflow;
        }

        #endregion

        #region other props

        public void SetMeasureFunc(MeasureFunc measureFunc)
        {
            Flex.SetMeasureFunc(this, measureFunc);
        }

        public MeasureFunc GetMeasureFunc()
        {
            return this.measureFunc;
        }

        public void SetBaselineFunc(BaselineFunc baselineFunc)
        {
            this.baselineFunc = baselineFunc;
        }

        public BaselineFunc GetBaselineFunc()
        {
            return this.baselineFunc;
        }

        public void SetPrintFunc(PrintFunc printFunc)
        {
            this.printFunc = printFunc;
        }

        public PrintFunc GetPrintFunc()
        {
            return this.printFunc;
        }
        #endregion

        #region tree
        public Node GetParent() => Parent;
        public IEnumerable<Node> GetChildrenIter() => Children;
        public Node GetChild(int idx)
        {
            return Flex.GetChild(this, idx);
        }
        public void AddChild(Node child)
        {
            if (child == null || child.Parent == this)
                return;

            Flex.InsertChild(this, child, ChildrenCount);
        }
        public int IndexOfChild(Node child)
        {
            return Children.IndexOf(child);
        }
        public void InsertChild(Node child, int idx)
        {
            if (child == null)
                return;

            Flex.InsertChild(this, child, idx);
        }
        public void RemoveChild(Node child)
        {
            Flex.RemoveChild(this, child);
        }
        public bool ReplaceChild(int index, Node child)
        {
            if (child == null)
                return false;

            if (0 <= index && index < ChildrenCount)
            {
                child.Parent = this;
                Children[index] = child;
                MarkAsDirty();
                return true;
            }

            return false;
        }
        public void SetParent(Node parent)
        {
            if (parent == Parent)
                return;

            RemoveParent();
            parent.AddChild(this);
        }
        public void RemoveParent()
        {
            if (Parent != null)
            {
                Parent.RemoveChild(this);
            }
        }
        #endregion
    }
}

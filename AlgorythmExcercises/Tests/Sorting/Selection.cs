using Common.Sorting;
using NUnit.Framework;

namespace Tests.Sorting;

public class Selection
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestArraySorted()
    {
        var array = new int[] { 5, 4, 3, 2, 1 };

        array.SelectionSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));
        
        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 2);
        Assert.AreEqual(array[2], 3);
        Assert.AreEqual(array[3], 4);
        Assert.AreEqual(array[4], 5);
    }
    
    [Test]
    public void TestEmptyArray()
    {
        var array = new int[0];

        array.SelectionSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));
    }
    
    [Test]
    public void TestArraySameValues()
    {
        var array = new int[]{1,1,1,1,1};

        array.SelectionSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));
        
        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 1);
        Assert.AreEqual(array[2], 1);
        Assert.AreEqual(array[3], 1);
        Assert.AreEqual(array[4], 1);
    }
    
    [Test]
    public void TestArraySortedComparable()
    {
        var array = new int[] { 5, 4, 3, 2, 1 };

        array.SelectionSort();
        
        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 2);
        Assert.AreEqual(array[2], 3);
        Assert.AreEqual(array[3], 4);
        Assert.AreEqual(array[4], 5);
    }
    
    [Test]
    public void TestEmptyArrayComparable()
    {
        var array = new int[0];

        array.SelectionSort();
    }
    
    [Test]
    public void TestArraySameValuesComparable()
    {
        var array = new int[]{1,1,1,1,1};

        array.SelectionSort();
        
        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 1);
        Assert.AreEqual(array[2], 1);
        Assert.AreEqual(array[3], 1);
        Assert.AreEqual(array[4], 1);
    }
}
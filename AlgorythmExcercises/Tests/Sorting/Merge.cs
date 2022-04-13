using Common.Sorting;
using NUnit.Framework;

namespace Tests.Sorting;

public class Merge
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestArraySorted()
    {
        var array = new int[] { 5, 4, 3, 2, 1 };

        array.MergeSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));

        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 2);
        Assert.AreEqual(array[2], 3);
        Assert.AreEqual(array[3], 4);
        Assert.AreEqual(array[4], 5);
    }

    [Test]
    public void TestArraySorted2()
    {
        var array = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        array.MergeSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));

        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 2);
        Assert.AreEqual(array[2], 3);
        Assert.AreEqual(array[3], 4);
        Assert.AreEqual(array[4], 5);
        Assert.AreEqual(array[5], 6);
        Assert.AreEqual(array[6], 7);
        Assert.AreEqual(array[7], 8);
        Assert.AreEqual(array[8], 9);
        Assert.AreEqual(array[9], 10);
    }

    [Test]
    public void TestEmptyArray()
    {
        var array = new int[0];

        array.MergeSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));
    }

    [Test]
    public void TestArraySameValues()
    {
        var array = new int[] { 1, 1, 1, 1, 1 };

        array.MergeSort((i1, i2) => i1 > i2 ? 1 : (i2 > i1 ? -1 : 0));

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

        array.MergeSort();

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

        array.MergeSort();
    }

    [Test]
    public void TestArraySameValuesComparable()
    {
        var array = new int[] { 1, 1, 1, 1, 1 };

        array.MergeSort();

        Assert.AreEqual(array[0], 1);
        Assert.AreEqual(array[1], 1);
        Assert.AreEqual(array[2], 1);
        Assert.AreEqual(array[3], 1);
        Assert.AreEqual(array[4], 1);
    }
}
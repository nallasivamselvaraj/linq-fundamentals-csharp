﻿namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region TakeQuery
    /// <summary>
    /// Use Take() to select a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> TakeQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products orderby prod.Name select prod).Take(5).ToList();

      return list;
    }
    #endregion

    #region TakeMethod
    /// <summary>
    /// Use Take() to select a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> TakeMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
     list = products.OrderBy(p => p.Name).Take(5).ToList();

      return list;
    }
    #endregion

    #region TakeRangeQuery
    /// <summary>
    /// Use Take() to select a specified number of items from a collection using the Range operator
    /// </summary>
    public List<Product> TakeRangeQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products orderby prod.Name select prod).Take(5..8).ToList();
      // Use the Range operator to select a range of items    
     
      return list;
    }
    #endregion

    #region TakeRangeMethod
    /// <summary>
    /// Use Take() to select a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> TakeRangeMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = products.OrderBy(p => p.Name).Take(5..8).ToList();

      return list;
    }
    #endregion

    #region TakeWhileQuery
    /// <summary>
    /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> TakeWhileQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products orderby prod.Name select prod).TakeWhile(p => p.Name.StartsWith("A")).ToList();

      return list;
    }
    #endregion

    #region TakeWhileMethod
    /// <summary>
    /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> TakeWhileMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
     list = products.OrderBy(p => p.Name).TakeWhile(p => p.Name.StartsWith("A")).ToList();

      return list;
    }
    #endregion

    #region SkipQuery
    /// <summary>
    /// Use Skip() to move past a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> SkipQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
        list = (from prod in products orderby prod.Name select prod).Skip(30).ToList();

      return list;
    }
    #endregion

    #region SkipMethod
    /// <summary>
    /// Use Skip() to move past a specified number of items from the beginning of a collection
    /// </summary>
    public List<Product> SkipMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.OrderBy(p => p.Name).Skip(30).ToList();

      return list;
    }
    #endregion

    #region SkipWhileQuery
    /// <summary>
    /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> SkipWhileQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
     list = (from prod in products orderby prod.Name select prod).SkipWhile(p => p.Name.StartsWith("A")).ToList(); 

      return list;
    }
    #endregion

    #region SkipWhileMethod
    /// <summary>
    /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
    /// </summary>
    public List<Product> SkipWhileMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
     list = products.OrderBy(p => p.Name).SkipWhile(p => p.Name.StartsWith("A")).ToList();

      return list;
    }
    #endregion

    #region DistinctQuery
    /// <summary>
    /// The Distinct() operator finds all unique values within a collection.
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> DistinctQuery()
    {
      List<Product> products = GetProducts();
      List<string> list = new();

      // Write Query Syntax Here
      list = (from prod in products select prod.Color).Distinct().OrderBy(c=>c). ToList();

      return list;
    }
    #endregion

    #region DistinctWhere
    /// <summary>
    /// The Distinct() operator finds all unique values within a collection.
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> DistinctWhere()
    {
      List<Product> products = GetProducts();
      List<string> list = new();

      // Write Method Syntax Here
      list = products.Select(p => p.Color).Distinct().OrderBy(c=>c).ToList();

      return list;
    }
    #endregion

    #region DistinctByQuery
    public List<Product> DistinctByQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products select prod).DistinctBy(p => p.Color).OrderBy(p=>p.Color).ToList();

      return list;
    }
    #endregion

    #region DistinctByMethod
    public List<Product> DistinctByMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.DistinctBy(p => p.Color).OrderBy(p=>p.Color).ToList();

      return list;
    }
    #endregion

    #region ChunkQuery
    /// <summary>
    /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
    /// </summary>
    public List<Product[]> ChunkQuery()
    {
      List<Product> products = GetProducts();
      List<Product[]> list = new();

      // Write Query Syntax Here
      list = (from prod in products orderby prod.Name select prod).Chunk(5).ToList();  

      return list;
    }
    #endregion

    #region ChunkMethod
    /// <summary>
    /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
    /// </summary>
    public List<Product[]> ChunkMethod()
    {
      List<Product> products = GetProducts();
      List<Product[]> list = new();

      // Write Method Syntax Here
      
      list = products.OrderBy(p => p.Name).Chunk(5).ToList();
      return list;
    }
    #endregion
  }
}

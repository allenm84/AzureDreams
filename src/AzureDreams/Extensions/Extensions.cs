﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDreams
{
  internal static class Extensions
  {
    public static T Fetch<T>(this IList<T> list, Random random)
    {
      int index = random.Next(list.Count);
      return list.PopAt(index);
    }

    public static T PopAt<T>(this IList<T> list, int index)
    {
      T value = list[index];
      list.RemoveAt(index);
      return value;
    }

    public static bool Any(this int value, params int[] values)
    {
      return values.Any(v => (v == value));
    }

    public static LinkedListNode<T> Next<T>(this LinkedListNode<T> node)
    {
      return node.Next ?? node.List.First;
    }

    public static LinkedListNode<T> Previous<T>(this LinkedListNode<T> node)
    {
      return node.Previous ?? node.List.Last;
    }
  }
}

using ipocs.objects.Objects;
using PostSharp.Patterns.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace ipocs.objects
{
  [NotifyPropertyChanged]
  public class Concentrator
  {
    public string Name { get; set; } = string.Empty;
    public ObservableCollection<BasicObject> Objects { get; set; } = new ObservableCollection<BasicObject>();

    public Concentrator()
    {
      foreach (Type o in Assembly.GetAssembly(typeof(BasicObject)).GetTypes().Where((t) => typeof(BasicObject).IsAssignableFrom(t) && !t.IsAbstract))
      {
        var bo = (BasicObject)Activator.CreateInstance(o);
        bo.Name = o.Name + " " + Objects.Count;
        Objects.Add(bo);
      }
    }

    public List<byte> Serialize()
    {
      var vector = new List<byte>();
      foreach (var basicObject in this.Objects)
      {
        var objectVector = basicObject.Serialize();
        vector.AddRange(objectVector);
      }
      return vector;
    }
  }
}

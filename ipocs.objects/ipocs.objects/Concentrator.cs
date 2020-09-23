using ipocs.objects.Objects;
using PostSharp.Patterns.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ipocs.objects
{
  [NotifyPropertyChanged]
  public class Concentrator
  {
    public string Name { get; set; } = string.Empty;
    public ObservableCollection<BasicObject> Objects { get; set; } = new ObservableCollection<BasicObject>();

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

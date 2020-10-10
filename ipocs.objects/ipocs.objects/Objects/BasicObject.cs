using PostSharp.Patterns.Model;
using System.Collections.Generic;

namespace ipocs.objects.Objects
{
  [NotifyPropertyChanged]
  public abstract class BasicObject
  {
    [SafeForDependencyAnalysis]
    public string TypeName { [Pure] get { return GetType().Name; } }

    public string Name { get; set; } = string.Empty;

    public abstract byte ObjectTypeId { get; }

    public override string ToString()
    {
      return Name;
    }

    public List<byte> Serialize()
    {
      var buffer = new List<byte>
      {
        this.ObjectTypeId
      };
      int lengthPos = buffer.Count;
      buffer.Add(0); // Length;
      byte[] toBytes = System.Text.Encoding.UTF8.GetBytes(this.Name);
      buffer.AddRange(toBytes);
      buffer.Add(0);
      this.Serialize(buffer);
      buffer[lengthPos] = (byte)(buffer.Count - lengthPos);
      return buffer;
    }

    protected abstract void Serialize(List<byte> buffer);
  }
}

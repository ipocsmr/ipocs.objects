using System.Collections.Generic;

namespace ipocs.objects.Objects
{
  public class SignalBoard : BasicObject
  {
    public override byte ObjectTypeId { get { return 25; } }

    public byte frequency { get; set; }
    public byte signalHead1 { get; set; }
    public byte signalHead2 { get; set; }
    public byte signalHead3 { get; set; }
    public byte signalHead4 { get; set; }
    public byte signalHead5 { get; set; }
    public byte signalHead6 { get; set; }

    protected override void Serialize(List<byte> buffer)
    {
      buffer.Add(frequency);
      buffer.Add(signalHead1);
      buffer.Add(signalHead2);
      buffer.Add(signalHead3);
      buffer.Add(signalHead4);
      buffer.Add(signalHead5);
      buffer.Add(signalHead6);
    }
  }
}

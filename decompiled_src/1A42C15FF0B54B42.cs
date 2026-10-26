using System.Collections.Generic;

public class _1A42C15FF0B54B42<_0001>(long P_0) where _0001 : C66C869F25E04CC3
{
	private readonly Queue<_0001> _3A7499BD1D70441C = new Queue<_0001>();

	private readonly long _14058969C44F4967 = P_0;

	public int F912CB261E164317 => _3A7499BD1D70441C.Count;

	public void _918CCD4D03A64F7C(_0001 P_0)
	{
		_3A7499BD1D70441C.Enqueue(P_0);
	}

	public void A96488F8354C4887(long P_0)
	{
		while (_3A7499BD1D70441C.Count > 0 && P_0 - _3A7499BD1D70441C.Peek()._226B7B943D07494C > _14058969C44F4967)
		{
			_3A7499BD1D70441C.Dequeue();
		}
	}

	public Queue<_0001>.Enumerator A2A766451ED44A51()
	{
		return _3A7499BD1D70441C.GetEnumerator();
	}
}

using System;
using System.Collections.Generic;

public class MessageHeader
{
	public class Message
	{
		public string message;

		public int errorLevel;

		public Message()
		{
			this.message = string.Empty;
		}
	}

	private List<MessageHeader.Message> msgs;

	public List<MessageHeader.Message> AllMessages
	{
		get
		{
			return this.msgs;
		}
	}

	public int MessageCount
	{
		get
		{
			return this.msgs.Count;
		}
	}

	public MessageHeader()
	{
		this.msgs = new List<MessageHeader.Message>();
	}

	public MessageHeader.Message LastMessage()
	{
		MessageHeader.Message result;
		if (this.msgs.Count > 0)
		{
			result = this.msgs[checked(this.msgs.Count - 1)];
		}
		else
		{
			result = null;
		}
		return result;
	}

	public MessageHeader.Message AllMessagesMessage()
	{
		MessageHeader.Message result;
		if (this.msgs.Count == 0)
		{
			result = null;
		}
		else
		{
			MessageHeader.Message message = new MessageHeader.Message();
            try
            {
                List<MessageHeader.Message>.Enumerator enumerator = this.msgs.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    MessageHeader.Message current = enumerator.Current;
                    if (message.errorLevel == 0 && current.errorLevel > 0)
                    {
                        message.errorLevel = current.errorLevel;
                    }
                    message.message = message.message + current.message + "\r\n";
                }
                ((IDisposable)enumerator).Dispose();
            }
            catch (Exception) { }
			result = message;
		}
		return result;
	}

	public bool AddMessage(string msg, int eal = 0)
	{
		MessageHeader.Message message = new MessageHeader.Message();
		message.message = msg;
		message.errorLevel = eal;
		this.msgs.Add(message);
		return true;
	}

	public bool AddMessage(MessageHeader.Message msh)
	{
		bool result;
		if (msh == null)
		{
			result = false;
		}
		else
		{
			this.msgs.Add(msh);
			result = true;
		}
		return result;
	}

	public bool Clear()
	{
		this.msgs.Clear();
		return true;
	}
}

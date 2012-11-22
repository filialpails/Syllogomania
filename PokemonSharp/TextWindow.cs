using System;

namespace PokemonSharp
{
	public class TextWindowShownEventArgs : EventArgs
	{
		public int Answer { get; set; }
	}

	public delegate void TextWindowShownEventHandler(object sender, TextWindowShownEventArgs e);

	public class TextWindow
	{
		public string[] Text { get; private set; }
		public string[] Options { get; private set; }
		public int Page { get; private set; }
		public bool IsQuestion { get; private set; }

		public TextWindow(string[] text, string[] options = null)
		{
			Text = text;
			if (options != null)
			{
				IsQuestion = true;
				Options = options;
			}
		}

		public void NextPage()
		{
			Page++;
			PageIncremented(this, EventArgs.Empty);
		}

		public event TextWindowShownEventHandler Shown;
		public event EventHandler PageIncremented;

		public int Show()
		{
			TextWindowShownEventArgs e = new TextWindowShownEventArgs();
			Shown(this, e);
			return e.Answer;
		}
	}
}

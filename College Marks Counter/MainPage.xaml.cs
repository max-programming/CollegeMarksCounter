namespace College_Marks_Counter;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	string GetEmotion(double marks)
	{
		if (marks <= 12) return "😃";
		if (marks <= 20) return "😐";
		if (marks <= 25) return "😥";
		return "😟";
	}

	private void OnCalculateClicked(object sender, EventArgs e)
	{
		int marks1 = int.Parse(Marks1Txt.Text);
        int marks2 = int.Parse(Marks2Txt.Text);

		double passingMarks = Math.Abs(((marks1 + marks2) / 2.5) - 40);
		string displayPassingMarks = string.Format("{0:0.00}", passingMarks);

		string emotion = GetEmotion(passingMarks);

        OutputLabel.Text = $"You have to score {displayPassingMarks} to pass {emotion}";
	}
}


// See https://aka.ms/new-console-template for more information
using MachineLearningFeel;


Console.WriteLine("Hello, World!");

//Load sample data
var sampleData = new MLModel1.ModelInput()
{
    Rev_id = 2.429755E+08F,
    Comment = @"You are just great",
    Year = 2005F,
    Logged_in = false,
    Ns = @"article",
    Sample = @"random",
    Split = @"train",
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);

Console.WriteLine(result.PredictedLabel);

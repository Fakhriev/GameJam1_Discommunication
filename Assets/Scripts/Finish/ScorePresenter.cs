using UnityEngine.UI;
using UnityEngine;


public abstract class ScorePresenter : MonoBehaviour, IScorePresentable
{
    public virtual Text GetScore()
    {
        throw new System.NotImplementedException();
    }

    public Text GetTitle()
    {
        throw new System.NotImplementedException();
    }
}

internal interface IScorePresentable
{
    public Text GetTitle();
    public Text GetScore();
}

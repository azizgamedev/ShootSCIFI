using System;
using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;

        private int _score;

        private void Awake()
        {
            UpdateScore();
        }

        private void UpdateScore()
        {
            _scoreText.text = $"Killed: {_score}";
        }

        public void AddScore(int addedScore)
        {
            _score += addedScore;
            UpdateScore();
        }
    }
}

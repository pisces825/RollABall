using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{

    // Œ±‚Ì“_”‚ğ•Û‘¶‚·‚é‚½‚ß‚Ì5‚Â—e—Ê‚Ì‚ ‚é”z—ñ‚ğéŒ¾
    int[] testScores = new int[5];
    List<int> testNum = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        // ”z—ñ‚É“_”‚ğ‘ã“ü
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;
        Debug.Log(testScores[1]); // 90

        // ‰‰K‡@
        int[] numbers = { 5, 8, 12, 7, 3 };
        Debug.Log(numbers[2]);

        // ‰‰K‡A
        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
        Debug.Log(fruits[2]);

        // ‰‰K‡B
        int[] scores = { 78, 85, 90, 72, 88, 60 };
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        Debug.Log(sum);

        testNum.Add(1); // ƒŠƒXƒg‚Ì0”Ô–Ú‚Ì—v‘f‚É1‚ğ’Ç‰Á(1)
        testNum.Add(2); // ƒŠƒXƒg‚Ì1”Ô–Ú‚Ì—v‘f‚É2‚ğ’Ç‰Á(1, 2)
        testNum.Add(3); // ƒŠƒXƒg‚Ì2”Ô–Ú‚Ì—v‘f‚É3‚ğ’Ç‰Á(1, 2, 3)
        Debug.Log(testNum[0]); //ƒŠƒXƒg‚ÌÅ‰‚Ì—v‘f‚ğæ“¾i1j
        testNum.Remove(2); // ƒŠƒXƒg“à‚Ìˆê’v‚·‚é—v‘f‚ğíœ(1, 3)
        Debug.Log(testNum.Count); // ƒŠƒXƒg‚Ì—v‘f”‚ğæ“¾i‚±‚Ìê‡A2j

        // ‰‰K‡@
        List<int> listNumbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int listNumber in listNumbers)
        {
            Debug.Log(listNumber);
        }

        // ‰‰K‡A
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
        colors.Remove("Green");
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }

        // ‰‰K‡B
        List<string> listFruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig" };
        if (listFruits.Contains("Cherry"))
        {
            Debug.Log("Cherry‚ªŠÜ‚Ü‚ê‚Ä‚¢‚é");
        }
        else
        {
            Debug.Log("Cherry‚ªŠÜ‚Ü‚ê‚Ä‚¢‚È‚¢");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
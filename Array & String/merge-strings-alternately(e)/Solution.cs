public string MergeAlternately(string word1, string word2) {
    int len1 = word1.Length, len2 = word2.Length;
    int min = Math.Min(len1, len2);
    var sb = new StringBuilder(len1 + len2);

    for (int i = 0; i < min; i++) {
        sb.Append(word1[i]).Append(word2[i]);
    }

    if (len1 > min) sb.Append(word1, min, len1 - min);
    if (len2 > min) sb.Append(word2, min, len2 - min);

    return sb.ToString();
}

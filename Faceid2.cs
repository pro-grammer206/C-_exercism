using System;
using System.Collections.Generic;

public class FacialFeatures : IEquatable<FacialFeatures>
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

    public bool Equals(FacialFeatures? other)
    {
        if (other == null) return false;
        if (this.EyeColor == other.EyeColor && this.PhiltrumWidth == other.PhiltrumWidth) return true;
        return false;
    }
    public override int GetHashCode() => (EyeColor, PhiltrumWidth).GetHashCode();

}

public class Identity : IEquatable<Identity>
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public bool Equals(Identity? other)
    {
        if (other is null) return false;
        if (this.Email == other.Email && this.FacialFeatures.Equals(other.FacialFeatures)) return true;
        return false;
    }
    public override int GetHashCode() => (Email, FacialFeatures).GetHashCode();
    // TODO: implement equality and GetHashCode() methods
}

public class Authenticator
{
    public HashSet<Identity> identityList { get; } = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        if (identity.Email == "admin@exerc.ism" && identity.FacialFeatures.EyeColor == "green" && identity.FacialFeatures.PhiltrumWidth == 0.9m) return true;
        return false;
    }

    public bool Register(Identity identity)
    {
        return identityList.Add(identity);
    }

    public bool IsRegistered(Identity identity)
    {
        return identityList.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return Object.ReferenceEquals(identityA, identityB);
    }
}

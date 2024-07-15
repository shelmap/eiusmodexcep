public bool Equals(Edge other)
{
    return this.Id == other.Id && this.Name == other.Name && this.Description == other.Description;
}

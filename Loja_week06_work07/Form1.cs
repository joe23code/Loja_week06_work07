namespace Loja_week06_work07;

public partial class Form_EquipmentManager : Form
{

    private readonly List<Equipment> items = new();

    private class Equipment
    {
        public string AssetTag { get; set; } = "";
        public string Name { get; set; } = "";
        public string Category { get; set; } = "";
        public string Location { get; set; } = "";
        public string Status { get; set; } = "Available";
    }

    public Form_EquipmentManager()
    {
        InitializeComponent();
        cboStatus.SelectedIndex = 0;
        LoadSampleData();
        RefreshGrid(items);
    }

    private void LoadSampleData()
    {
        items.Add(new Equipment { AssetTag = "EQ-101", Name = "Laptop", Category = "Computer", Location = "Room 204", Status = "Available" });
        items.Add(new Equipment { AssetTag = "EQ-102", Name = "Projector", Category = "Audio-Visual", Location = "Library", Status = "Checked Out" });
        items.Add(new Equipment { AssetTag = "EQ-103", Name = "Camera", Category = "Media", Location = "Room 108", Status = "Under Maintenance" });
    }


    private void RefreshGrid(IEnumerable<Equipment> list)
    {
        dgv.Rows.Clear();
        foreach (var e in list)
            dgv.Rows.Add(e.AssetTag, e.Name, e.Category, e.Location, e.Status);
    }

    private void btnSearch_Click(object? sender, EventArgs e)
    {
        string term = txtSearch.Text.Trim();
        if (term.Length == 0)
        {
            RefreshGrid(items);
            return;
        }

        var results = items.Where(i =>
            i.AssetTag.Contains(term, StringComparison.OrdinalIgnoreCase) ||
            i.Name.Contains(term, StringComparison.OrdinalIgnoreCase)).ToList();

        RefreshGrid(results);
        if (results.Count == 0)
            MessageBox.Show("No equipment found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnShowAll_Click(object? sender, EventArgs e)
    {
        txtSearch.Clear();
        RefreshGrid(items);
    }

    private void btnUpdateStatus_Click(object? sender, EventArgs e)
    {
        if (dgv.CurrentRow == null)
        {
            MessageBox.Show("Please select a row first.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string tag = dgv.CurrentRow.Cells["colAssetTag"].Value?.ToString() ?? "";
        var item = items.FirstOrDefault(i => i.AssetTag == tag);
        if (item == null) return;

        item.Status = cboStatus.SelectedItem?.ToString() ?? item.Status;
        dgv.CurrentRow.Cells["colStatus"].Value = item.Status;
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        string tag = txtAssetTag.Text.Trim();
        string name = txtEquipment.Text.Trim();

        if (tag.Length == 0 || name.Length == 0)
        {
            MessageBox.Show("Asset tag and equipment name are required.", "Missing Information",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (items.Any(i => i.AssetTag.Equals(tag, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("An item with that asset tag already exists.", "Duplicate",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        items.Add(new Equipment
        {
            AssetTag = tag,
            Name = name,
            Category = txtCategory.Text.Trim(),
            Location = txtLocation.Text.Trim(),
            Status = "Available"
        });

        txtSearch.Clear();
        RefreshGrid(items);
        txtAssetTag.Clear(); txtEquipment.Clear(); txtCategory.Clear(); txtLocation.Clear();
    }

    private void lblHeader_Click(object sender, EventArgs e)
    {

    }

    private void lblSearch_Click(object sender, EventArgs e)
    {

    }
}

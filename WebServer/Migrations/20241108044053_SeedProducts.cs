using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebServer.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity", "Vendorcode" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 195977.4f, 194, 7085620 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 142086.56f, 294, 8062596 },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 199883.53f, 223, 5283477 },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 186310.73f, 342, 7614644 },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 124062.84f, 170, 2062152 },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 139336.16f, 267, 1062017 },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 175293.6f, 476, 7167541 },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 176201.28f, 260, 5362800 },
                    { 9, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 123460f, 209, 5056715 },
                    { 10, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 131545.11f, 230, 6756049 },
                    { 11, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 170480.34f, 178, 1446214 },
                    { 12, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 105373.02f, 312, 8373948 },
                    { 13, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 167475f, 356, 9059606 },
                    { 14, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 134403.05f, 237, 1152479 },
                    { 15, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 111919.984f, 369, 9239595 },
                    { 16, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 100576.07f, 232, 5924304 },
                    { 17, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 116529.766f, 305, 4274701 },
                    { 18, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 151642.31f, 275, 5523603 },
                    { 19, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 116536.59f, 60, 4989383 },
                    { 20, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 173847.55f, 237, 8314411 },
                    { 21, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 108579.92f, 393, 5018855 },
                    { 22, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 152052.12f, 217, 7451374 },
                    { 23, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 164904.73f, 196, 7166602 },
                    { 24, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 182402.61f, 137, 2794390 },
                    { 25, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 193035.23f, 464, 8227786 },
                    { 26, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 141730.08f, 15, 6480433 },
                    { 27, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 156948.69f, 30, 4170937 },
                    { 28, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 191243.19f, 255, 3347152 },
                    { 29, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 108193.01f, 41, 7753437 },
                    { 30, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 169651.6f, 276, 3025148 },
                    { 31, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 137812.75f, 92, 9840367 },
                    { 32, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 132819.03f, 401, 2125720 },
                    { 33, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 113757.09f, 87, 4713380 },
                    { 34, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 164680.19f, 85, 3997063 },
                    { 35, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 199362.78f, 5, 8641694 },
                    { 36, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 174043.4f, 380, 7161461 },
                    { 37, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 104657.74f, 287, 5335127 },
                    { 38, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 186281.9f, 434, 4418221 },
                    { 39, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 189860.3f, 385, 3548451 },
                    { 40, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 104188.65f, 461, 4774645 },
                    { 41, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 147836.19f, 216, 5065993 },
                    { 42, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 122633.82f, 64, 3246486 },
                    { 43, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 192215.78f, 315, 6430590 },
                    { 44, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 182436.4f, 301, 5855319 },
                    { 45, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 174904.31f, 449, 4682938 },
                    { 46, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 176413.16f, 174, 8081579 },
                    { 47, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 131312.8f, 205, 6091373 },
                    { 48, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 112282.2f, 401, 1883531 },
                    { 49, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 155782.9f, 36, 2744963 },
                    { 50, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convallis. Donec ornare lacus sed elit viverra, sed sodales nulla gravida. Praesent malesuada velit arcu, non fermentum diam sollicitudin et. Fusce lobortis neque id porta porta. Nulla posuere risus ac faucibus fringilla. Vestibulum ultricies cursus interdum. Donec pharetra nunc tincidunt, consectetur nunc id, pharetra est. Duis sed tincidunt libero. Integer ut egestas nunc. Nullam commodo accumsan ante.", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In condimentum vehicula lectus ut convalli", 189300.02f, 333, 1999883 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}

import { Col, Row } from 'antd';
import ProductCard from './ProductCard';

const ProductsGrid = ({ productsData }) => {

    var productRows = productsData.map((product) => (
        <Row key={product.Id}>
            <ProductCard product={product} />
        </Row>
    ));

    return (
        <Col className="cards-grid">
            {productRows}
        </Col>
    );
};

export default ProductsGrid;
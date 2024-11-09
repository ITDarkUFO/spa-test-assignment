import React from 'react'
import { Col, Row } from 'antd'
import ProductCard from './ProductCard'

const CardsList = ({ productsData, onDelete }) => {
    const handleDelete = (productId) => {
        onDelete((products) => products.filter((product) => product.Id != productId));
    };

    return (
        <Col className="cards-list-col">
            {
                productsData.map((product) => (
                    <Row key={product.Id}>
                        <ProductCard product={product} onDelete={handleDelete} />
                    </Row>
                ))
            }
        </Col>
    );
}

export default CardsList;